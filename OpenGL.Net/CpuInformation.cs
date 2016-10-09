
// Copyright (C) 2011-2016 Luca Piccioni
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
	/// SIMD technologies supported.
	/// </summary>
	[Flags()]
	public enum SimdTechnology
	{
		/// <summary>
		/// No support.
		/// </summary>
		None =			0x00000000,
		/// <summary>
		/// MMX technology.
		/// </summary>
		MMX =			0x00000001,
		/// <summary>
		/// SSE technology.
		/// </summary>
		SSE =			0x00000002,
		/// <summary>
		/// SSE2 technology.
		/// </summary>
		SSE2 =			0x00000004,
		/// <summary>
		/// SSE3 technology.
		/// </summary>
		SSE3 =			0x00000008,
		/// <summary>
		/// SSSE3 technology.
		/// </summary>
		SSSE3 =			0x00000010,
		/// <summary>
		/// SSE4 technology.
		/// </summary>
		SSE4 =			0x00000020,
		/// <summary>
		/// AVX technology.
		/// </summary>
		AVX =			0x00000100,
		/// <summary>
		/// MMX technology.
		/// </summary>
		Amd3DNow =		0x00010000,
	/// <summary>
		/// MMX technology.
		/// </summary>
		Amd3DNow2 =		0x00020000,
	}

	/// <summary>
	/// Other techonology supported.
	/// </summary>
	public enum OtherTechnology
	{
		/// <summary>
		/// No support.
		/// </summary>
		None =			0x00000000,
		/// <summary>
		/// TSC counter.
		/// </summary>
		TSC =			0x00000001,
	}

	/// <summary>
	/// CPU information.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Ansi)]
	public struct CpuInformation
	{
		/// <summary>
		/// CPU vendor.
		/// </summary>
		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string Vendor;

		/// <summary>
		/// Processor type.
		/// </summary>
		[FieldOffset(16)]
		public int ProcessorType;

		/// <summary>
		/// Processor family.
		/// </summary>
		[FieldOffset(20)]
		public int Family;

		/// <summary>
		/// Processor family extended.
		/// </summary>
		[FieldOffset(24)]
		public int FamilyExtended;

		/// <summary>
		/// Processor model.
		/// </summary>
		[FieldOffset(28)]
		public int Model;

		/// <summary>
		/// Processor model extended.
		/// </summary>
		[FieldOffset(32)]
		public int ModelExtended;

		/// <summary>
		/// Processor model.
		/// </summary>
		[FieldOffset(36)]
		public int Stepping;

		/// <summary>
		/// Processor SIMD support.
		/// </summary>
		[FieldOffset(40)]
		public SimdTechnology SimdSupport;

		/// <summary>
		/// Processor other support.
		/// </summary>
		[FieldOffset(44)]
		public OtherTechnology OtherSupport;
	}
}
