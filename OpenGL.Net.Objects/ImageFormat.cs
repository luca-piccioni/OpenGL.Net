
// Copyright (C) 2009-2017 Luca Piccioni
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

namespace OpenGL.Objects
{
	/// <summary>
	/// Known image container format enumeration.
	/// </summary>
	public sealed class ImageFormat
	{
		/// <summary>
		/// Windows bitmap container.
		/// </summary>
		[MediaFormatAttribute("Bitmap", LongDescription="Device Independent Bitmap", FileExtensions = "bmp|dib")]
		public const string Bitmap = "Bitmap";

		/// <summary>
		/// Windows icon.
		/// </summary>
		[MediaFormatAttribute("Ico", LongDescription="Windows icon", FileExtensions = "ico")]
		public const string Ico = "Ico";

		/// <summary>
		/// Independent JPEG Group container.
		/// </summary>
		[MediaFormatAttribute("JPEG", LongDescription="Joint Photographic Experts Group", FileExtensions = "jpeg|jpg|jpe|jfif|jif")]
		public const string Jpeg = "Jpeg";

		/// <summary>
		/// JPEG-2000 container.
		/// </summary>
		[MediaFormatAttribute("JPEG 2000", LongDescription="Joint Photographic Experts Group JPEG2000", FileExtensions = "j2k|j2c|jp2|jpc|pgx")]
		public const string Jpeg2000 = "Jpeg2000";

		/// <summary>
		/// JPEG Network Graphics container.
		/// </summary>
		[MediaFormatAttribute("JNG", LongDescription="JPEG Network Graphics", FileExtensions = "jng")]
		public const string Jng = "Jng";

		/// <summary>
		/// Multiple Network Graphics container.
		/// </summary>
		[MediaFormatAttribute("MNG", LongDescription="Multiple Network Graphics", FileExtensions = "mng")]
		public const string Mng = "Mng";

		/// <summary>
		/// Portable Network Graphics container.
		/// </summary>
		[MediaFormatAttribute("PNG", LongDescription="Portable Network Graphics", FileExtensions = "png")]
		public const string Png = "Png";

		/// <summary>
		/// Tagged Image File container.
		/// </summary>
		[MediaFormatAttribute("TIFF", LongDescription="Tagged Image File Format", FileExtensions = "tif|tiff|tif2")]
		public const string Tiff = "Tiff";

		/// <summary>
		/// Truevision Targa container.
		/// </summary>
		[MediaFormatAttribute("Targa", LongDescription="Truevision Targa", FileExtensions = "targa|tga")]
		public const string Targa = "Targa";

		/// <summary>
		/// EXIF container.
		/// </summary>
		[MediaFormatAttribute("Exif", LongDescription="EXIF Container", FileExtensions = "exif|exig")]
		public const string Exif = "Exif";

		/// <summary>
		/// GIF container.
		/// </summary>
		[MediaFormatAttribute("GIF", LongDescription="Graphics Interleaved Format", FileExtensions = "gif")]
		public const string Gif = "Gif";

		/// <summary>
		/// EXR container.
		/// </summary>
		[MediaFormatAttribute("EXR", LongDescription="EXR High-Definition Range", FileExtensions = "exr")]
		public const string Exr = "Exr";

		/// <summary>
		/// HDR container.
		/// </summary>
		[MediaFormatAttribute("HDR", LongDescription="RADIANCE High Definition Range (RGBE)", FileExtensions = "hdr|rad|pic")]
		public const string Hdr = "Hdr";

		/// <summary>
		/// Portable bitmap.
		/// </summary>
		[MediaFormatAttribute("PBM", LongDescription="Portable Bitmap", FileExtensions = "pbm|pnm")]
		public const string Pbm = "Pbm";

		/// <summary>
		/// Portable pixelmap
		/// </summary>
		[MediaFormatAttribute("PPM", LongDescription="Portable Pixmap", FileExtensions = "ppm|pnm")]
		public const string Ppm = "Ppm";

		/// <summary>
		/// Portable graymap
		/// </summary>
		[MediaFormatAttribute("PGM", LongDescription="Portable Graymap", FileExtensions = "pgm|pnm")]
		public const string Pgm = "Pgm";

		/// <summary>
		/// Portable floatmap
		/// </summary>
		[MediaFormatAttribute("PFM", LongDescription="Portable Float Map", FileExtensions = "pfm|pnm")]
		public const string Pfm = "Pfm";

		/// <summary>
		/// Kodak PhotoCD container.
		/// </summary>
		[MediaFormatAttribute("PCD", LongDescription="Kodak PhotoCD", FileExtensions = "pcd")]
		public const string KodakPcd = "KodakPcd";

		/// <summary>
		/// Zsoft Paintbrush PCX bitmap container
		/// </summary>
		[MediaFormatAttribute("PCX", LongDescription="Zsoft Paintbrush PCX bitmap", FileExtensions = "pcx")]
		public const string Pcx = "Pcx";

		/// <summary>
		/// RAW camera container.
		/// </summary>
		/// <remarks>
		/// ".3fr":	Hasselblad Digital Camera Raw Image Format.
		/// ".arw": Sony Digital Camera Raw Image Format for Alpha devices.
		/// ".bay": Casio Digital Camera Raw File Format.
		/// ".bmq": NuCore Raw Image File.
		/// ".cap": Phase One Digital Camera Raw Image Format.
		/// ".cine": Phantom Software Raw Image File.
		/// ".cr2": Canon Digital Camera RAW Image Format version 2.0. These images are based on the TIFF image standard.
		/// ".crw": Canon Digital Camera RAW Image Format version 1.0.
		/// extList.Add(".cs1": Sinar Capture Shop Raw Image File.
		/// ".dc2": Kodak DC25 Digital Camera File.
		/// ".dcr": Kodak Digital Camera Raw Image Format for these models: Kodak DSC Pro SLR/c, Kodak DSC Pro SLR/n, Kodak DSC Pro 14N, Kodak DSC PRO 14nx.
		/// ".drf": Kodak Digital Camera Raw Image Format.
		/// ".dsc": Kodak Digital Camera Raw Image Format.
		/// ".dng": Adobe Digital Negative: DNG is publicly available archival format for the raw files generated by digital cameras.
		/// 		By addressing the lack of an open standard for the raw files created by individual camera models, DNG helps ensure that
		/// 		photographers will be able to access their files in the future.
		/// ".erf": Epson Digital Camera Raw Image Format.
		/// ".fff": Imacon Digital Camera Raw Image Format.
		/// ".ia":  Sinar Raw Image File.
		/// ".iiq": Phase One Digital Camera Raw Image Format.
		/// ".k25": Kodak DC25 Digital Camera Raw Image Format.
		/// ".kc2": Kodak DCS200 Digital Camera Raw Image Format.
		/// ".kdc": Kodak Digital Camera Raw Image Format.
		/// ".mdc": Minolta RD175 Digital Camera Raw Image Format.
		/// ".mef": Mamiya Digital Camera Raw Image Format.
		/// ".mos": Leaf Raw Image File.
		/// ".mrw": Minolta Dimage Digital Camera Raw Image Format.
		/// ".nef": Nikon Digital Camera Raw Image Format.
		/// ".nrw": Nikon Digital Camera Raw Image Format.
		/// ".orf": Olympus Digital Camera Raw Image Format.
		/// ".pef": Pentax Digital Camera Raw Image Format.
		/// ".ptx": Pentax Digital Camera Raw Image Format.
		/// ".pxn": Logitech Digital Camera Raw Image Format.
		/// ".qtk": Apple Quicktake 100/150 Digital Camera Raw Image Format.
		/// ".raf": Fuji Digital Camera Raw Image Format.
		/// ".raw": Panasonic Digital Camera Image Format.
		/// ".rdc": Digital Foto Maker Raw Image File.
		/// ".rw2": Panasonic LX3 Digital Camera Raw Image Format.
		/// ".rwl": Leica Camera Raw Image Format.
		/// ".rwz": Rawzor Digital Camera Raw Image Format.
		/// ".sr2": Sony Digital Camera Raw Image Format.
		/// ".srf": Sony Digital Camera Raw Image Format for DSC-F828 8 megapixel digital camera or Sony DSC-R1
		/// ".sti": Sinar Capture Shop Raw Image File.
		/// 
		/// FileExtensions = "3fr|arw|bay|bmq|cap|cine|cr2|crw|cs1|dc2|dcr|drf|dsc|dng|erf|fff|ia|iiq|k25|kc2|kdc|mdc|mef|mos|mrw|nef|nrw|orf|pef|ptx|pxn|qtk|raf|raw|rdc|rw2|rwl|rwz|sr2|srf|sti"
		/// </remarks>
		[MediaFormatAttribute("Raw", LongDescription = "Raw Image", FileExtensions = "3fr|arw|bay|bmq|cap|cine|cr2|crw|cs1|dc2|dcr|drf|dsc|dng|erf|fff|ia|iiq|k25|kc2|kdc|mdc|mef|mos|mrw|nef|nrw|orf|pef|ptx|pxn|qtk|raf|raw|rdc|rw2|rwl|rwz|sr2|srf|sti")]
		public const string Raw = "Raw";

		/// <summary>
		/// DTED.
		/// </summary>
		[MediaFormatAttribute("DTED", LongDescription = "Digital Terrain Elevation Data", FileExtensions = "dt0|dt1|dt2|dt3")]
		public const string Dted = "DTED";

		/// <summary>
		/// SMRT.
		/// </summary>
		[MediaFormatAttribute("SMRT", LongDescription = "Digital Terrain Elevation Data", FileExtensions = "hgt")]
		public const string Smrt = "SMRT";

		/// <summary>
		/// Virtual data set.
		/// </summary>
		[MediaFormatAttribute("VRT", LongDescription = "Virtual Data Set", FileExtensions = "vrt")]
		public const string Vrt = "VRT";

		/// <summary>
		/// Unknown container.
		/// </summary>
		[MediaFormatAttribute("Any", Abstract = true)]
		public const string Unknown = "Unknown";
	}
}