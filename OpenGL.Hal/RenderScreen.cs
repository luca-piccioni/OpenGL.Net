
// Copyright (C) 2010-2012 Luca Piccioni
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//  
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//  
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Screen abstraction.
	/// </summary>
	public class RenderScreen
	{
		#region Gamma Function Control

		/// <summary>
		/// Get the current gamma ramp.
		/// </summary>
		/// <param name="hDC"></param>
		/// <returns></returns>
		public static GammaRamp GetGammaRamp(IntPtr hDC)
		{
			GammaRamp ramp = new GammaRamp();

			if (GetDeviceGammaRamp(hDC, ref ramp) == false)
				throw new InvalidOperationException("GetDeviceGammaRamp has failed");

			return (ramp);
		}

		/// <summary>
		/// Set the current gamma ramp to any ramp supplied.
		/// </summary>
		/// <param name="hDC"></param>
		/// <param name="ramp"></param>
		public static void SetGammaRamp(IntPtr hDC, ref GammaRamp ramp)
		{
			if (SetDeviceGammaRamp(hDC, ref ramp) == false)
				throw new InvalidOperationException("SetDeviceGammaRamp has failed");
		}

		/// <summary>
		/// Set the current gamma ramp to compensate monitor gamma.
		/// </summary>
		/// <param name="hDC"></param>
		/// <param name="gamma"></param>
		public static void SetGammaRamp(IntPtr hDC, double gamma)
		{
			SetGammaRamp(hDC, gamma, gamma, gamma);
		}

		/// <summary>
		/// Set the current gamma ramp to compensate monitor gamma.
		/// </summary>
		/// <param name="hDC"></param>
		/// <param name="rgamma"></param>
		/// <param name="ggamma"></param>
		/// <param name="bgamma"></param>
		public static void SetGammaRamp(IntPtr hDC, double rgamma, double ggamma, double bgamma)
		{
			GammaRamp ramp = new GammaRamp();

			// Build gamma ramp in order to compensate monitor gamma
			ramp.Red = new UInt16[256];
			ramp.Green = new UInt16[256];
			ramp.Blue = new UInt16[256];

			for (uint v = 0; v < 256; v++) {
				double gamma;

				// Red ramp
				gamma = Math.Min(1.0, Math.Pow((double)v / 255.0, 1.0 / rgamma));
				ramp.Red[v] = (UInt16)((double)UInt16.MaxValue * gamma);

				// Green ramp
				gamma = Math.Min(1.0, Math.Pow((double)v / 255.0, 1.0 / rgamma));
				ramp.Green[v] = (UInt16)((double)UInt16.MaxValue * gamma);

				// Blue ramp
				gamma = Math.Min(1.0, Math.Pow((double)v / 255.0, 1.0 / rgamma));
				ramp.Blue[v] = (UInt16)((double)UInt16.MaxValue * gamma);
			}

			// Set ramp
			SetGammaRamp(hDC, ref ramp);
		}

		/// <summary>
		/// Gamma ramp.
		/// </summary>
		[StructLayout(LayoutKind.Sequential, CharSet=CharSet.Ansi)]
		public struct GammaRamp {
			/// <summary>
			/// Red gamma ramp.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] 
			public UInt16[] Red;
			/// <summary>
			/// Green gamma ramp.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] 
			public UInt16[] Green;
			/// <summary>
			/// Blue gamma ramp.
			/// </summary>
			[MarshalAs(UnmanagedType.ByValArray, SizeConst=256)] 
			public UInt16[] Blue;

			/// <summary>
			/// Get a rought (averaged) measure of the gamma correction applied to red component.
			/// </summary>
			/// <returns>
			/// It returns a gamma value roughly representing the red gamma response curve.
			/// </returns>
			public double GetRoughtRedGammaCorrection()
			{
				return (GetRoughtGammaCorrection(Red));
			}

			/// <summary>
			/// Get a rought (averaged) measure of the gamma correction applied to green component.
			/// </summary>
			/// <returns>
			/// It returns a gamma value roughly representing the green gamma response curve.
			/// </returns>
			public double GetRoughtGreenGammaCorrection()
			{
				return (GetRoughtGammaCorrection(Green));
			}

			/// <summary>
			/// Get a rought (averaged) measure of the gamma correction applied to blue component.
			/// </summary>
			/// <returns>
			/// It returns a gamma value roughly representing the blue gamma response curve.
			/// </returns>
			public double GetRoughtBlueGammaCorrection()
			{
				return (GetRoughtGammaCorrection(Blue));
			}

			/// <summary>
			/// Get a rought (averaged) measure of the gamma correction applied to red, green and blue components.
			/// </summary>
			/// <returns>
			/// It returns a gamma value roughly representing the red, green and blue gamma response curves.
			/// </returns>
			public double GetRoughtGammaCorrection()
			{
				return ((GetRoughtRedGammaCorrection() + GetRoughtGreenGammaCorrection() + GetRoughtBlueGammaCorrection()) / 3.0);
			}

			/// <summary>
			/// Get a rought (averaged) measure of the gamma correction applied to one component.
			/// </summary>
			/// <returns>
			/// It returns a gamma value roughly representing the gamma response curves.
			/// </returns>
			private static double GetRoughtGammaCorrection(UInt16[] ramp)
			{
				double avggamma = 0.0;
				uint avggammasamples = 0;

				for (int i = 0; i < 255; i++, avggammasamples++) {
					if (ramp[i] != 0)
						avggamma += Math.Log10((double)ramp[i] / (double)UInt16.MaxValue) / Math.Log10((double)i / (double)Byte.MaxValue);
					else
						avggamma += 1.0;
				}

				return ((double)avggammasamples / avggamma);
			}
		}

		[DllImport("gdi32.dll", CallingConvention=CallingConvention.StdCall, EntryPoint="SetDeviceGammaRamp")]
		private static extern bool SetDeviceGammaRamp(IntPtr hDC, ref GammaRamp lpRamp);

		[DllImport("gdi32.dll", CallingConvention=CallingConvention.StdCall, EntryPoint="GetDeviceGammaRamp")]
		private static extern bool GetDeviceGammaRamp(IntPtr hDC, ref GammaRamp lpRamp);

		#endregion
	}
}
