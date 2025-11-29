
// Copyright (C) 2021 Luca Piccioni
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

// Supported shader versions:
// - 1.5 or higher

#include </Geo/GeoProject.glsl>

#if defined(GLO_GEOPROJECTION_HP)
#define FLOAT double

#include </OpenGL/Math.glsl>
#else
#define FLOAT float
#endif

// https://svnweb.freebsd.org/base/head/lib/msun/src/

// Minimum precision to get to terminate projection
uniform FLOAT glo_GeoProjectMinPrecision = 1.0e-12;
// Maximum number of iterations allowed
uniform int glo_GeoProjectMaxIterations = 20;

vec2 GeoProject(const VEC2 coord)
{
	const FLOAT CONST_A = 6378137.0;
	const FLOAT CONST_B = 6356752.3142;
	const FLOAT CONST_F = 0.00335281066474;
	const FLOAT CONST_E_PRIMO_QUADRO = 6.73949674227e-3;

	FLOAT ldPHI1 = radians(glo_GeoProjectOrigin[1]);
	FLOAT ldPHI2 = radians(coord[1]);
	FLOAT ldLAMBDA1 = radians(glo_GeoProjectOrigin[0]);
	FLOAT ldLAMBDA2 = radians(coord[0]);

	// check coincident points
	const FLOAT ldLimit = 1.0e-15;

	if ((abs(ldPHI1 - ldPHI2) < ldLimit) && (abs(ldLAMBDA2 - ldLAMBDA1) < ldLimit))
		return (vec2(0.0, 0.0));	//invalid....coincident WPs

	FLOAT ldU1 = atan((1.0 - CONST_F) * tan(ldPHI1));
	FLOAT ldU2 = atan((1.0 - CONST_F) * tan(ldPHI2));
	FLOAT ldOMEGA = ldLAMBDA2 - ldLAMBDA1;
	FLOAT ldLAMBDA = ldOMEGA;	// difference in longitude on auxiliary sphere
	FLOAT ldOLD_LAMBDA = 1000;
	int liCNT = 0;

	FLOAT ldSinQuadroSigma;
	FLOAT ldCosSigma;
	FLOAT ldSinSigma;
	FLOAT ldCosQuadroAlfa;
	FLOAT ldCos2sigmaM;
	FLOAT ldSIGMA;

	while ((abs(ldLAMBDA - ldOLD_LAMBDA) > glo_GeoProjectMinPrecision) && (liCNT < glo_GeoProjectMaxIterations)) {
		liCNT++;
		FLOAT ldTemp1 = cos(ldU2) * sin(ldLAMBDA);
		FLOAT ldTemp2 = cos(ldU1) * sin(ldU2) - sin(ldU1) * cos(ldU2) * cos(ldLAMBDA);

		ldSinQuadroSigma = ldTemp1 * ldTemp1 + ldTemp2 * ldTemp2;

		ldSinSigma = sqrt(ldSinQuadroSigma);
		ldCosSigma = sin(ldU1) * sin(ldU2) + cos(ldU1) * cos(ldU2) * cos(ldLAMBDA);

		FLOAT ldSinAlfa = cos(ldU1) * cos(ldU2) * sin(ldLAMBDA) / ldSinSigma;

		ldCosQuadroAlfa = 1 - ldSinAlfa * ldSinAlfa;

		if (ldCosQuadroAlfa == 0) {
			ldCos2sigmaM = 0;
		} else {
			ldCos2sigmaM = ldCosSigma - 2.0 * sin(ldU1) * sin(ldU2) / (ldCosQuadroAlfa);
		}

		FLOAT ldC = (CONST_F / 16.0) * (ldCosQuadroAlfa) * (4.0 + CONST_F * (4.0 - 3.0 * (ldCosQuadroAlfa)));

		ldSIGMA = atan(ldSinSigma, ldCosSigma);
		ldOLD_LAMBDA = ldLAMBDA;
		ldLAMBDA = ldOMEGA + (1.0 - ldC) * CONST_F * ldSinAlfa * (ldSIGMA + ldC * ldSinSigma * (ldCos2sigmaM + ldC * ldCosSigma * (-1.0 + 2.0 * (ldCos2sigmaM * ldCos2sigmaM))));
	}

	FLOAT ldUQuadro = (ldCosQuadroAlfa) * CONST_E_PRIMO_QUADRO;

	FLOAT ldA = 1.0 + (ldUQuadro / 16384.0) * (4096.0 + ldUQuadro * (-768.0 + ldUQuadro * (320.0 - 175.0 * ldUQuadro)));
	FLOAT ldB = (ldUQuadro / 1024.0) * (256.0 + ldUQuadro * (-128.0 + ldUQuadro * (74.0 - 47.0 * ldUQuadro)));

	FLOAT ldDeltaSigma=
		ldB * ldSinSigma * (ldCos2sigmaM + (ldB / 4.0) * (ldCosSigma * (-1.0 + 2.0 * (ldCos2sigmaM * ldCos2sigmaM)) -
		(ldB /6.0 ) * ldCos2sigmaM * (-3.0 + 4.0 *ldSinQuadroSigma) * (-3.0 + 4.0 * ldCos2sigmaM * ldCos2sigmaM)));

	// [1.5]
	FLOAT aDistance = CONST_B * ldA * (ldSIGMA - ldDeltaSigma); // distance in [m]
	// [1.6]
	FLOAT aAngle12 = atan((cos(ldU2) * sin(ldLAMBDA)), ( cos(ldU1) * sin(ldU2) - sin(ldU1) * cos(ldU2) * cos(ldLAMBDA)));
	//float aAngle21 = atan((cos(ldU1) * sin(ldLAMBDA)), (-sin(ldU1) * cos(ldU2) + cos(ldU1) * sin(ldU2) * cos(ldLAMBDA))) + 3.14;

	FLOAT x = aDistance * sin(aAngle12);
	FLOAT y = aDistance * cos(aAngle12);

	return vec2(float(x), float(y));
}
