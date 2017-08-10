
// Copyright (C) 2016-2017 Luca Piccioni
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

// Adaptation in C# from https://github.com/chrisveness/geodesy/blob/master/latlon-vincenty.js

/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
/* Vincenty Direct and Inverse Solution of Geodesics on the Ellipsoid (c) Chris Veness 2002-2016  */
/*                                                                                   MIT Licence  */
/* www.movable-type.co.uk/scripts/latlong-vincenty.html                                           */
/* www.movable-type.co.uk/scripts/geodesy/docs/module-latlon-vincenty.html                        */
/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */

using System;

namespace OpenGL.Objects
{
	/// <summary>
	/// Vincenty projection implementation.
	/// </summary>
	/// <remarks>
	/// Implementation base on 
	/// </remarks>
	public static class Vincenty
	{
		/// <summary>
		/// Direct solution: compute distance and bearing from two points.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="rng"></param>
		/// <param name="brg"></param>
		/// <param name="v2"></param>
		public static void Direct(Vertex2d v1, double rng, double brg, out Vertex2d v2)
		{
			const int MaxIterations = 200;
			const double Precision = 1e-12;

			const double a = 6378137.0;			// Major axisσʹ
			const double b = 6356752.3142;		// Minor axis
			const double f = (a - b) / a;		// Flattening

			double φ1 = Angle.ToRadians(v1.y), λ1 = Angle.ToRadians(v1.x);
			double α1 = Angle.ToRadians(brg);
			double s = rng;

			double sinα1 = Math.Sin(α1);
			double cosα1 = Math.Cos(α1);

			double tanU1 = (1.0 - f) * Math.Tan(φ1), cosU1 = 1.0 / Math.Sqrt((1.0 + tanU1 * tanU1)), sinU1 = tanU1 * cosU1;
			double σ1 = Math.Atan2(tanU1, cosα1);
			double sinα = cosU1 * sinα1;
			double cosSqα = 1.0 - sinα * sinα;
			double uSq = cosSqα * (a * a - b * b) / (b * b);
			double A = 1 + uSq / 16384.0 * (4096.0 + uSq * (-768.0 + uSq * (320.0 - 175.0 * uSq)));
			double B = uSq / 1024.0 * (256.0 + uSq * (-128.0 + uSq * (74.0 - 47.0 * uSq)));

			double cos2σM, sinσ, cosσ, Δσ;

			double σ = s / (b * A);
			int iterations = 0;
			do {
				cos2σM = Math.Cos(2.0 * σ1 + σ);
				sinσ = Math.Sin(σ);
				cosσ = Math.Cos(σ);
				Δσ = B * sinσ * (cos2σM + B / 4 * (cosσ * (-1.0 + 2.0 * cos2σM * cos2σM) - B / 6.0 * cos2σM * (-3.0 + 4.0 * sinσ * sinσ) * (-3.0 + 4.0 * cos2σM * cos2σM)));
				σ1 = σ;
				σ = s / (b * A) + Δσ;
			} while (Math.Abs(σ - σ1) > Precision && ++iterations < MaxIterations);

			if (iterations >= MaxIterations) throw new Exception("failed to converge"); // not possible?

			double x = sinU1 * sinσ - cosU1 * cosσ * cosα1;
			double φ2 = Math.Atan2(sinU1 * cosσ + cosU1 * sinσ * cosα1, (1.0 - f) * Math.Sqrt(sinα * sinα + x * x));
			double λ = Math.Atan2(sinσ * sinα1, cosU1 * cosσ - sinU1 * sinσ * cosα1);
			double C = f / 16.0 * cosSqα * (4 + f * (4 - 3 * cosSqα));
			double L = λ - (1.0 - C) * f * sinα * (σ + C * sinσ * (cos2σM + C * cosσ * (-1.0 + 2.0 * cos2σM * cos2σM)));
			double λ2 = (λ1 + L + 3.0 * Math.PI) % (2.0 * Math.PI) - Math.PI;  // normalise to -180..+180

			double α2 = Math.Atan2(sinα, -x);
			α2 = (α2 + 2.0 * Math.PI) % (2.0 * Math.PI); // normalise to 0..360

			v2 = new Vertex2d(Angle.ToDegrees(λ2), Angle.ToDegrees(φ2));

			// Final bearing: Angle.ToDegrees(α2)
		}

		/// <summary>
		/// Inverse solution: compute the point given distance and bearing from a point.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <param name="rng"></param>
		/// <param name="brg"></param>
		public static void Inverse(Vertex2d v1, Vertex2d v2, out double rng, out double brg)
		{
			const int MaxIterations = 200;
			const double Precision = 1e-12;

			const double a = 6378137.0;			// Major axis
			const double b = 6356752.3142;		// Minor axis
			const double f = (a - b) / a;		// Flattening

			double φ1 = Angle.ToRadians(v1.y), λ1 = Angle.ToRadians(v1.x);
			double φ2 = Angle.ToRadians(v2.y), λ2 = Angle.ToRadians(v2.x);

			double L = λ2 - λ1;
			double tanU1 = (1.0 - f) * Math.Tan(φ1), cosU1 = 1.0 / Math.Sqrt((1.0 + tanU1 * tanU1)), sinU1 = tanU1 * cosU1;
			double tanU2 = (1.0 - f) * Math.Tan(φ2), cosU2 = 1.0 / Math.Sqrt((1.0 + tanU2 * tanU2)), sinU2 = tanU2 * cosU2;

			double sinλ, cosλ, sinSqσ, sinσ, cosσ, σ, sinα, cosSqα, cos2σM, C;

			rng = brg = 0.0; // Suppose coincident points

			double λ = L;
			int iterations = 0;
			do {
				sinλ = Math.Sin(λ);
				cosλ = Math.Cos(λ);
				sinSqσ = (cosU2 * sinλ) * (cosU2 * sinλ) + (cosU1 * sinU2 - sinU1 * cosU2 * cosλ) * (cosU1 * sinU2 - sinU1 * cosU2 * cosλ);
				sinσ = Math.Sqrt(sinSqσ);
				if (Math.Abs(sinσ) < Double.Epsilon) return;        // co-incident points
				cosσ = sinU1 * sinU2 + cosU1 * cosU2 * cosλ;
				σ = Math.Atan2(sinσ, cosσ);
				sinα = cosU1 * cosU2 * sinλ / sinσ;
				cosSqα = 1.0 - sinα * sinα;
				cos2σM = cosσ - 2.0 * sinU1 * sinU2 / cosSqα;
				if (Double.IsNaN(cos2σM)) cos2σM = 0;               // equatorial line: cosSqα=0 (§6)
				C = f / 16.0 * cosSqα * (4.0 + f * (4.0 - 3.0 * cosSqα));
				λ1 = λ;
				λ = L + (1.0 - C) * f * sinα * (σ + C * sinσ * (cos2σM + C * cosσ * (-1.0 + 2.0 * cos2σM * cos2σM)));
			} while (Math.Abs(λ - λ1) > Precision && ++iterations < MaxIterations);

			if (iterations >= MaxIterations)
				throw new Exception("failed to converge");

			double uSq = cosSqα * (a * a - b * b) / (b * b);
			double A = 1.0 + uSq / 16384.0 * (4096.0 + uSq * (-768.0 + uSq * (320.0 - 175.0 * uSq)));
			double B = uSq / 1024.0 * (256.0 + uSq * (-128.0 + uSq * (74.0 - 47.0 * uSq)));
			double Δσ = B * sinσ * (cos2σM + B / 4.0 * (cosσ * (-1.0 + 2.0 * cos2σM * cos2σM) - B / 6.0 * cos2σM * (-3.0 + 4.0 * sinσ * sinσ) * (-3.0 + 4.0 * cos2σM * cos2σM)));

			double s = b * A * (σ - Δσ);

			double α1 = Math.Atan2(cosU2 * sinλ, cosU1 * sinU2 - sinU1 * cosU2 * cosλ);
			double α2 = Math.Atan2(cosU1 * sinλ, -sinU1 * cosU2 + cosU1 * sinU2 * cosλ);

			α1 = (α1 + 2.0 * Math.PI) % (2.0 * Math.PI); // normalise to 0..360
			α2 = (α2 + 2.0 * Math.PI) % (2.0 * Math.PI); // normalise to 0..360

			rng = s;
			brg = Angle.ToDegrees(α1);      // Otherwise Angle.ToDegrees(α2)
		}

		/// <summary>
		/// Get the distance between two points.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static double GetDistance(Vertex2d v1, Vertex2d v2)
		{
			double rng, brg;

			Inverse(v1, v2, out rng, out brg);

			return (rng);
		}
	}
}
