
// Copyright (C) 2009-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;

namespace OpenGL.Objects.State
{
	/// <summary>
	/// Blend render state (buffer group, color).
	/// </summary>
	[DebuggerDisplay("BlendState: Enabled={Enabled} Src={SrcFactor} Dst={DstFactor} Eq={Equation} SrcAlpha={AlphaSrcFactor} DstAlpha={AlphaDstFactor} Inheritable={Inheritable}")]
	public class BlendState : GraphicsState
	{
		#region Constructors
		
		/// <summary>
		/// Construct a default BlendState (blending disabled).
		/// </summary>
		public BlendState()
		{
			
		}

		/// <summary>
		/// Construct a BlendState with unified RGB/Alpha function.
		/// </summary>
		/// <param name="equation">
		/// A <see cref="BlendEquationModeEXT"/> flag indicating which equation to used for blending.
		/// </param>
		/// <param name="srcFactor">
		/// A <see cref="BlendingFactorSrc"/> that specify the scaling factors applied to the source color (including alpha).
		/// </param>
		/// <param name="dstFactor">
		/// A <see cref="BlendingFactorDest"/> that specify the scaling factors applied to the destination color (including alpha).
		/// </param>
		public BlendState(BlendEquationModeEXT equation, BlendingFactorSrc srcFactor, BlendingFactorDest dstFactor) :
			this(equation, equation, srcFactor, srcFactor, dstFactor, dstFactor, new ColorRGBAF())
		{
			
		}

		/// <summary>
		/// Construct a BlendState with unified RGB/Alpha function.
		/// </summary>
		/// <param name="equation">
		/// A <see cref="BlendEquationModeEXT"/> flag indicating which equation to used for blending.
		/// </param>
		/// <param name="srcFactor">
		/// A <see cref="BlendingFactorSrc"/> that specify the scaling factors applied to the source color (including alpha).
		/// </param>
		/// <param name="dstFactor">
		/// A <see cref="BlendingFactorDest"/> that specify the scaling factors applied to the destination color (including alpha).
		/// </param>
		/// <param name="constColor">
		/// A <see cref="ColorRGBAF"/> that specify the constant color used in blending functions.
		/// </param>
		public BlendState(BlendEquationModeEXT equation, BlendingFactorSrc srcFactor, BlendingFactorDest dstFactor, ColorRGBAF constColor) :
			this(equation, equation, srcFactor, srcFactor, dstFactor, dstFactor, constColor)
		{
			
		}

		/// <summary>
		/// Construct a BlendState with separated RGB/Alpha functions.
		/// </summary>
		/// <param name="rgbEquation">
		/// A <see cref="BlendEquationModeEXT"/> flag indicating which equation to used for blending RGB color components.
		/// </param>
		/// <param name="alphaEquation">
		/// A <see cref="BlendEquationModeEXT"/> flag indicating which equation to used for blending Alpha color component.
		/// </param>
		/// <param name="srcRgbFactor">
		/// A <see cref="BlendingFactorSrc"/> that specify the scaling factors applied to the source color (alpha component excluded).
		/// </param>
		/// <param name="srcAlphaFactor">
		/// A <see cref="BlendingFactorSrc"/> that specify the scaling factors applied to only the source alpha component.
		/// </param>
		/// <param name="dstRgbFactor">
		/// A <see cref="BlendingFactorDest"/> that specify the scaling factors applied to the destination color (alpha component excluded).
		/// </param>
		/// <param name="dstAlphaFactor">
		/// A <see cref="BlendingFactorDest"/> that specify the scaling factors applied to only the destination alpha component.
		/// </param>
		public BlendState(BlendEquationModeEXT rgbEquation, BlendEquationModeEXT alphaEquation, BlendingFactorSrc srcRgbFactor, BlendingFactorSrc srcAlphaFactor, BlendingFactorDest dstRgbFactor, BlendingFactorDest dstAlphaFactor) :
			this(rgbEquation, alphaEquation, srcRgbFactor, srcAlphaFactor, dstRgbFactor, dstAlphaFactor, new ColorRGBAF())
		{
			
		}

		/// <summary>
		/// Construct a BlendState with separated RGB/Alpha functions.
		/// </summary>
		/// <param name="rgbEquation">
		/// A <see cref="BlendEquationModeEXT"/> flag indicating which equation to used for blending RGB color components.
		/// </param>
		/// <param name="alphaEquation">
		/// A <see cref="BlendEquationModeEXT"/> flag indicating which equation to used for blending Alpha color component.
		/// </param>
		/// <param name="srcRgbFactor">
		/// A <see cref="BlendingFactorSrc"/> that specify the scaling factors applied to the source color (alpha component excluded).
		/// </param>
		/// <param name="srcAlphaFactor">
		/// A <see cref="BlendingFactorSrc"/> that specify the scaling factors applied to only the source alpha component.
		/// </param>
		/// <param name="dstRgbFactor">
		/// A <see cref="BlendingFactorDest"/> that specify the scaling factors applied to the destination color (alpha component excluded).
		/// </param>
		/// <param name="dstAlphaFactor">
		/// A <see cref="BlendingFactorDest"/> that specify the scaling factors applied to only the destination alpha component.
		/// </param>
		/// <param name="constColor">
		/// A <see cref="ColorRGBAF"/> that specify the constant color used in blending functions.
		/// </param>
		public BlendState(BlendEquationModeEXT rgbEquation, BlendEquationModeEXT alphaEquation, BlendingFactorSrc srcRgbFactor, BlendingFactorSrc srcAlphaFactor, BlendingFactorDest dstRgbFactor, BlendingFactorDest dstAlphaFactor, ColorRGBAF constColor)
		{
			if (IsSupportedEquation(rgbEquation) == false)
				throw new ArgumentException("not supported blending equation " + srcRgbFactor, "rgbEquation");
			if (IsSupportedEquation(alphaEquation) == false)
				throw new ArgumentException("not supported blending equation " + alphaEquation, "rgbEquation");
			if (IsSupportedFunction(srcRgbFactor) == false)
				throw new ArgumentException("not supported blending function " + srcRgbFactor, "srcRgbFactor");
			if (IsSupportedFunction(srcAlphaFactor) == false)
				throw new ArgumentException("not supported blending function " + srcAlphaFactor, "srcAlphaFactor");
			if (IsSupportedFunction(dstRgbFactor) == false)
				throw new ArgumentException("not supported blending function " + dstRgbFactor, "dstRgbFactor");
			if (IsSupportedFunction(dstAlphaFactor) == false)
				throw new ArgumentException("not supported blending function " + dstAlphaFactor, "dstAlphaFactor");

			// Blend enabled
			_Enabled = true;

			// Store RGB separate equation
			_RgbEquation = rgbEquation;
			// Store alpha separate equation
			_AlphaEquation = alphaEquation;

			// Store rgb separate function
			_RgbSrcFactor = srcRgbFactor;
			_RgbDstFactor = dstRgbFactor;
			// Store alpha separate function
			_AlphaSrcFactor = srcAlphaFactor;
			_AlphaDstFactor = dstAlphaFactor;
			// Store blend color
			_BlendColor = constColor;

			if (EquationSeparated && !Gl.CurrentExtensions.BlendEquationSeparate_EXT)
				throw new InvalidOperationException("not supported separated blending equations");
			if (FunctionSeparated && !Gl.CurrentExtensions.BlendFuncSeparate_EXT)
				throw new InvalidOperationException("not supported separated blending functions");
		}

		/// <summary>
		/// Construct the current BlendState.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> defining this GraphicsState.
		/// </param>
		public BlendState(GraphicsContext ctx)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			int blendRgbEquation, blendAlphaEquation;
			int blendRgbSrcFunct, blendAlphaSrcFunct;
			int blendRgbDstFunct, blendAlphaDstFunct;

			// Blend enabled
			_Enabled = Gl.IsEnabled(EnableCap.Blend);

			if (Gl.CurrentExtensions.BlendEquationSeparate_EXT) {
				// Blend equation (RGB)
				Gl.Get(Gl.BLEND_EQUATION_RGB, out blendRgbEquation);
				// Blend equation (Alpha)
				Gl.Get(Gl.BLEND_EQUATION_ALPHA, out blendAlphaEquation);
			} else {
				if (Gl.CurrentExtensions.BlendMinmax_EXT) {
					// Blend equation (RGBA)
					Gl.Get(GetPName.BlendEquation, out blendRgbEquation);
					// Alpha equation is the same for RGB!
					blendAlphaEquation = blendRgbEquation;
				} else {
					blendRgbEquation = blendAlphaEquation = (int)BlendEquationModeEXT.FuncAdd;
				}
			}

			if (Gl.CurrentExtensions.BlendFuncSeparate_EXT) {
				// Blend source function (RGB)
				Gl.Get(Gl.BLEND_SRC_RGB, out blendRgbSrcFunct);
				// Blend source function (Alpha)
				Gl.Get(Gl.BLEND_SRC_ALPHA, out blendAlphaSrcFunct);
				// Blend destination function (RGB)
				Gl.Get(Gl.BLEND_DST_RGB, out blendRgbDstFunct);
				// Blend destination function (Alpha)
				Gl.Get(Gl.BLEND_DST_ALPHA, out blendAlphaDstFunct);
			} else {
				// Blend source function (RGBA)
				Gl.Get(GetPName.BlendSrc, out blendRgbSrcFunct);
				blendAlphaSrcFunct = blendRgbSrcFunct;
				// Blend destination function (RGBA)
				Gl.Get(GetPName.BlendDst, out blendRgbDstFunct);
				blendAlphaDstFunct = blendRgbDstFunct;
			}

			// Store blending equation
			_RgbEquation = (BlendEquationModeEXT)blendRgbEquation;
			_AlphaEquation = (BlendEquationModeEXT)blendAlphaEquation;

			// Store blending function
			_RgbSrcFactor = (BlendingFactorSrc)blendRgbSrcFunct;
			_AlphaSrcFactor = (BlendingFactorSrc)blendAlphaSrcFunct;
			_RgbDstFactor = (BlendingFactorDest)blendRgbDstFunct;
			_AlphaDstFactor = (BlendingFactorDest)blendAlphaDstFunct;

			// Store blend color
			if (Gl.CurrentExtensions.BlendColor_EXT) {
				float[] blendColor = new float[4];

				Gl.Get(GetPName.BlendColor, blendColor);

				_BlendColor = new ColorRGBAF(blendColor[0], blendColor[1], blendColor[2], blendColor[3]);
			}
		}

		#endregion
		
		#region Blend Render State Definition

		/// <summary>
		/// Determine whether the blending is enabled.
		/// </summary>
		public bool Enabled { get { return (_Enabled); } }
		
		/// <summary>
		/// Determine whether blending equation is separated for RGB and Alpha components.
		/// </summary>
		public bool EquationSeparated { get { return (_RgbEquation != _AlphaEquation); } }

		/// <summary>
		/// Blend equation for RGB components.
		/// </summary>
		public BlendEquationModeEXT RgbEquation { get { return (_RgbEquation); } }

		/// <summary>
		/// Blend equation for alpha components.
		/// </summary>
		public BlendEquationModeEXT AlphaEquation { get { return (_AlphaEquation); } }

		/// <summary>
		/// Determine whether blending function is separated for RGB and Alpha components.
		/// </summary>
		public bool FunctionSeparated { get { return ((_RgbSrcFactor != _AlphaSrcFactor) || (_RgbDstFactor != _AlphaDstFactor)); } }

		/// <summary>
		/// Source blending factor.
		/// </summary>
		public BlendingFactorSrc SrcFactor { get { return (_RgbSrcFactor); } set { _RgbSrcFactor = _AlphaSrcFactor = value; } }

		/// <summary>
		/// Destination blending factor.
		/// </summary>
		public BlendingFactorDest DstFactor { get { return (_RgbDstFactor); } set { _RgbDstFactor = _AlphaDstFactor = value; } }

		/// <summary>
		/// RGB source blending factor.
		/// </summary>
		public BlendingFactorSrc RgbSrcFactor { get { return (_RgbSrcFactor); } set { _RgbSrcFactor = value; } }

		/// <summary>
		/// RGB destination blending factor.
		/// </summary>
		public BlendingFactorDest RgbDstFactor { get { return (_RgbDstFactor); } set { _RgbDstFactor = value; } }

		/// <summary>
		/// Alpha source blending factor.
		/// </summary>
		public BlendingFactorSrc AlphaSrcFactor { get { return (_AlphaSrcFactor); } set { _AlphaSrcFactor = value; } }

		/// <summary>
		/// Alpha destination blending factor.
		/// </summary>
		public BlendingFactorDest AlphaDstFactor { get { return (_AlphaDstFactor); } set { _AlphaDstFactor = value; } }

		/// <summary>
		/// Constant blending color.
		/// </summary>
		public ColorRGBAF BlendColor { get { return (_BlendColor); } set { _BlendColor = value; } }

		/// <summary>
		/// Determine whether a blending function is supported.
		/// </summary>
		/// <param name="equation"></param>
		/// <returns></returns>
		private static bool IsSupportedEquation(BlendEquationModeEXT equation)
		{
			switch (equation) {
				case BlendEquationModeEXT.Min:
				case BlendEquationModeEXT.Max:
					return (Gl.CurrentExtensions.BlendMinmax_EXT);
				case BlendEquationModeEXT.FuncSubtract:
				case BlendEquationModeEXT.FuncReverseSubtract:
					return (Gl.CurrentExtensions.BlendSubtract_EXT);
				default:
					return (true);
			}
		}

		/// <summary>
		/// Determine whether a blending function is supported.
		/// </summary>
		/// <param name="func"></param>
		/// <returns></returns>
		private static bool IsSupportedFunction(BlendingFactorSrc func)
		{
			switch (func) {
				case BlendingFactorSrc.ConstantColor:
				case BlendingFactorSrc.OneMinusConstantColor:
				case BlendingFactorSrc.ConstantAlpha:
				case BlendingFactorSrc.OneMinusConstantAlpha:
					return (Gl.CurrentExtensions.BlendColor_EXT);
				default:
					return (true);
			}
		}

		/// <summary>
		/// Determine whether a blending function is supported.
		/// </summary>
		/// <param name="func"></param>
		/// <returns></returns>
		private static bool IsSupportedFunction(BlendingFactorDest func)
		{
			switch (func) {
				case BlendingFactorDest.ConstantColor:
				case BlendingFactorDest.OneMinusConstantColor:
				case BlendingFactorDest.ConstantAlpha:
				case BlendingFactorDest.OneMinusConstantAlpha:
					return (Gl.CurrentExtensions.BlendColor_EXT);
				default:
					return (true);
			}
		}

		private static bool RequiresConstColor(BlendingFactorSrc func)
		{
			switch (func) {
				case BlendingFactorSrc.ConstantColor:
				case BlendingFactorSrc.OneMinusConstantColor:
				case BlendingFactorSrc.ConstantAlpha:
				case BlendingFactorSrc.OneMinusConstantAlpha:
					return (true);
				default:
					return (false);
			}
		}

		private static bool RequiresConstColor(BlendingFactorDest func)
		{
			switch (func) {
				case BlendingFactorDest.ConstantColor:
				case BlendingFactorDest.OneMinusConstantColor:
				case BlendingFactorDest.ConstantAlpha:
				case BlendingFactorDest.OneMinusConstantAlpha:
					return (true);
				default:
					return (false);
			}
		}

		/// <summary>
		/// Enabled flag.
		/// </summary>
		private bool _Enabled;

		/// <summary>
		/// Blend equation for RGB components.
		/// </summary>
		private BlendEquationModeEXT _RgbEquation = BlendEquationModeEXT.FuncAdd;

		/// <summary>
		/// Blend equation for alpha components.
		/// </summary>
		private BlendEquationModeEXT _AlphaEquation = BlendEquationModeEXT.FuncAdd;
		
		/// <summary>
		/// RGB source blending factor.
		/// </summary>
		private BlendingFactorSrc _RgbSrcFactor = BlendingFactorSrc.One;

		/// <summary>
		/// RGB destination blending factor.
		/// </summary>
		private BlendingFactorDest _RgbDstFactor = BlendingFactorDest.Zero;

		/// <summary>
		/// Alpha source blending factor.
		/// </summary>
		private BlendingFactorSrc _AlphaSrcFactor = BlendingFactorSrc.One;

		/// <summary>
		/// Alpha destination blending factor.
		/// </summary>
		private BlendingFactorDest _AlphaDstFactor = BlendingFactorDest.Zero;

		/// <summary>
		/// Constant blending color.
		/// </summary>
		private ColorRGBAF _BlendColor;
		
		#endregion

		#region Default State

		/// <summary>
		/// The system default state for BlendState.
		/// </summary>
		public static BlendState DefaultState { get { return (new BlendState()); } }

		#endregion

		#region GraphicsState Overrides

		/// <summary>
		/// The identifier of the state.
		/// </summary>
		public const string StateId = "OpenGL.Blend";

		/// <summary>
		/// The identifier of this GraphicsState.
		/// </summary>
		public override string StateIdentifier { get { return (StateId); } }

		/// <summary>
		/// Set ShaderProgram state.
		/// </summary>
		/// <param name="ctx">
		/// A <see cref="GraphicsContext"/> which has defined the shader program <paramref name="sProgram"/>.
		/// </param>
		/// <param name="sProgram">
		/// The <see cref="ShaderProgram"/> which has the state set.
		/// </param>
		public override void ApplyState(GraphicsContext ctx, ShaderProgram sProgram)
		{
			if (ctx == null)
				throw new ArgumentNullException("ctx");

			if (Enabled) {
				// Enable blending
				Gl.Enable(EnableCap.Blend);

				// Set blending equation
				if (Gl.CurrentExtensions.BlendMinmax_EXT) {
					if (EquationSeparated)
						Gl.BlendEquationSeparate(RgbEquation, AlphaEquation);
					else
						Gl.BlendEquation((int)RgbEquation);
				}

				// Set blending function
				if (FunctionSeparated)
					Gl.BlendFuncSeparate((int)_RgbSrcFactor, (int)_RgbDstFactor, (int)_AlphaSrcFactor, (int)_AlphaDstFactor);
				else
					Gl.BlendFunc(_RgbSrcFactor, _RgbDstFactor);

				// Set blend color, if required
				if (RequiresConstColor(_RgbSrcFactor) || RequiresConstColor(_AlphaSrcFactor) || RequiresConstColor(_RgbDstFactor) || RequiresConstColor(_AlphaDstFactor)) {
					Gl.BlendColor(_BlendColor.Red, _BlendColor.Green, _BlendColor.Blue, _BlendColor.Alpha);
				}
			} else {
				// Disable blending
				Gl.Disable(EnableCap.Blend);
			}
		}

		/// <summary>
		/// Merge this state with another one.
		/// </summary>
		/// <param name="state">
		/// A <see cref="IGraphicsState"/> having the same <see cref="StateIdentifier"/> of this state.
		/// </param>
		public override void Merge(IGraphicsState state)
		{
			if (state == null)
				throw new ArgumentNullException("state");

			BlendState otherState = state as BlendState;

			if (otherState == null)
				throw new ArgumentException("not a BlendState", "state");

			_Enabled = otherState._Enabled;
			_RgbEquation = otherState._RgbEquation;
			_AlphaEquation = otherState._AlphaEquation;
			_RgbSrcFactor = otherState._RgbSrcFactor;
			_AlphaSrcFactor = otherState._AlphaSrcFactor;
			_RgbDstFactor = otherState._RgbDstFactor;
			_AlphaDstFactor = otherState._AlphaDstFactor;
			_BlendColor = otherState._BlendColor;
		}

		/// <summary>
		/// Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">
		/// A <see cref="GraphicsState"/> to compare to this GraphicsState.
		/// </param>
		/// <returns>
		/// It returns true if the current object is equal to <paramref name="other"/>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// This method test only whether <paramref name="other"/> type equals to this type.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentNullException">
		/// This exception is thrown if the parameter <paramref name="other"/> is null.
		/// </exception>
		public override bool Equals(IGraphicsState other)
		{
			if (base.Equals(other) == false)
				return (false);
			Debug.Assert(other is BlendState);

			BlendState otherState = (BlendState) other;

			if (otherState._Enabled != _Enabled)
				return (false);
			if ((otherState.RgbEquation != RgbEquation) || (otherState.AlphaEquation != AlphaEquation))
				return (false);
			if ((otherState.RgbSrcFactor != RgbSrcFactor) || (otherState.RgbDstFactor != RgbDstFactor))
				return (false);
			if ((otherState.AlphaSrcFactor != AlphaSrcFactor) || (otherState.AlphaDstFactor != AlphaDstFactor))
				return (false);

			return (true);
		}
		
		/// <summary>
		/// Represents the current <see cref="GraphicsState"/> for logging.
		/// </summary>
		/// <returns>
		/// A <see cref="String"/> that represents the current <see cref="GraphicsState"/>.
		/// </returns>
		public override string ToString()
		{
			System.Text.StringBuilder sb = new System.Text.StringBuilder();
			
			if (Enabled) {
				sb.AppendFormat("{0}: ", StateIdentifier);
				if (EquationSeparated)
					sb.AppendFormat("RgbEquation={0} AlphaEquation={1} ", RgbEquation, AlphaEquation);
				else
					sb.AppendFormat("BlendEquationModeEXT={0} ", RgbEquation);
				if (FunctionSeparated)
					sb.AppendFormat("RgbSrcFactor={0} RgbDstFactor={1} AlphaSrcFactor={2} AlphaDstFactor={3} ", RgbSrcFactor, RgbDstFactor, AlphaSrcFactor, AlphaDstFactor);
				else
					sb.AppendFormat("RgbSrcFactor={0} RgbDstFactor={1} ", RgbSrcFactor, RgbDstFactor);
					
				if (RequiresConstColor(RgbSrcFactor) || RequiresConstColor(RgbDstFactor))
					sb.AppendFormat("BlendColor={0} ", BlendColor);
				
				sb.Remove(sb.Length - 1, 1);
			} else
				sb.AppendFormat("{0}: Enabled=false", StateIdentifier);
			
			return (sb.ToString());
		}
		
		#endregion
	}
}
