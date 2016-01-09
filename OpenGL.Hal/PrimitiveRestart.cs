
// Copyright (c) 2013 Luca Piccioni
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

namespace OpenGL
{
	/// <summary>
	/// Utility class for managing the primitive restart.
	/// </summary>
	static class PrimitiveRestart
	{
		public static bool IsPrimitiveRestartSupported(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			return (ctx.Caps.GlExtensions.PrimitiveRestart || ctx.Caps.GlExtensions.PrimitiveRestart_NV);
		}

		public static void EnablePrimitiveRestart(GraphicsContext ctx, uint index)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			if (ctx.IsCurrent)
				throw new ArgumentException("not current", "ctx");

			if (ctx.Caps.GlExtensions.PrimitiveRestart) {
				// Enable primitive restart (server state)
				Gl.Enable(EnableCap.PrimitiveRestart);
				// Specify restart index
				Gl.PrimitiveRestartIndex(index);
			} else if(ctx.Caps.GlExtensions.PrimitiveRestart_NV) {
				// Enable primitive restart (client state)
				Gl.EnableClientState(EnableCap.PrimitiveRestartNv);
				// Specify restart index
				Gl.PrimitiveRestartIndexNV(index);
			} else
				throw new InvalidOperationException("primitive restart not supported");
		}
		
		public static void EnablePrimitiveRestart(GraphicsContext ctx, ushort index)
		{
			EnablePrimitiveRestart(ctx, index);
		}
		
		public static void EnablePrimitiveRestart(GraphicsContext ctx, byte index)
		{
			EnablePrimitiveRestart(ctx, index);
		}
		
		public static void EnablePrimitiveRestart(GraphicsContext ctx, DrawElementsType elementType)
		{
			switch (elementType) {
				case DrawElementsType.UnsignedInt:
					EnablePrimitiveRestart(ctx, UInt32.MaxValue);
					break;
				case DrawElementsType.UnsignedShort:
					EnablePrimitiveRestart(ctx, UInt16.MaxValue);
					break;
				case DrawElementsType.UnsignedByte:
					EnablePrimitiveRestart(ctx, Byte.MaxValue);
					break;
				default:
					throw new ArgumentException(String.Format("unknown element type {0}", elementType));
			}
		}
		
		public static void DisablePrimitiveRestart(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");
			
			if (ctx.Caps.GlExtensions.PrimitiveRestart) {
				// Enable primitive restart (server state)
				Gl.Disable(EnableCap.PrimitiveRestart);
			} else if (ctx.Caps.GlExtensions.PrimitiveRestart_NV) {
				// Enable primitive restart (client state)
				Gl.DisableClientState(EnableCap.PrimitiveRestartNv);
			} else
				throw new InvalidOperationException("primitive restart not supported");
		}
	}
}

