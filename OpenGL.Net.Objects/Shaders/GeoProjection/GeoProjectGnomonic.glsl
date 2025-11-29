
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

#include </OpenGL/GeoProject.glsl>

// Compute the Earth ellipsoid radius given a latitude
float ComputeEarthRadius(const float lat)
{
	// Earth ellipse major semi-axis
	const float a = 6378388.0;
	// Earth ellipse minor semi-axis
	const float b = 6356911.94613;

	// Convert latitude in radians and compute its sin
	float sphi = sin(radians(lat));

	// Compute the square of Earth ellipse eccentricity
	// Note: e^2 = (a^2 - b^2)/a^2  -->  e2 = 1 - b^2/a^2
	float e2 = 1.0 - (b * b) / (a * a);

	return (a * sqrt(1.0 - e2 * sphi * sphi));
}

vec2 GeoProject(const vec2 coord)
{
	float lon = coord[0], lat = coord[1];

	float cosphi = cos(radians(lat));
	float sinphi = sin(radians(lat));
	float eradius = ComputeEarthRadius(lat);
	float coscphi = cos(radians(glo_GeoProjectOrigin[1]));
	float sincphi = sin(radians(glo_GeoProjectOrigin[1]));
	float cosdeltalambda = cos(radians(lon - glo_GeoProjectOrigin[0]));
	float sindeltalambda = sin(radians(lon - glo_GeoProjectOrigin[0]));
	float a = sincphi * sinphi + coscphi * cosdeltalambda * cosphi;

	vec2 cartesian;

	cartesian[0] = eradius * (cosphi *                     sindeltalambda         ) / a;
	cartesian[1] = eradius * (sinphi * coscphi - sincphi * cosdeltalambda * cosphi) / a;

	return (cartesian);
}