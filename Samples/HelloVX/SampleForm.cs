using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenVX;

namespace HelloVX
{
	public partial class SampleForm : Form
	{
		public SampleForm()
		{
			InitializeComponent();
		}

		private void SampleForm_Load(object sender, EventArgs e)
		{
			_Context = VX.CreateContext();
			_ImageInput = VX.CreateImage(_Context, 256, 256, DfImage.Rgb);

			_Pyramid = VX.CreatePyramid(_Context, lk_pyramid_levels, lk_pyramid_scale, 256, 256, DfImage.U8);
			_PyramidDelay = VX.CreateDelay(_Context, _Pyramid, 2);
			VX.Release(_Pyramid);

			_KeypointsExemplar = VXCreateArray(_Context, VX.TYPE_KEYPOINT, max_keypoint_count);
			_KeypointsDelay = VX.CreateDelay(_Context, _KeypointsExemplar, 2);
		}

		private void SampleForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			VX.Release(_Context);
		}

		private Context _Context;

		private OpenVX.Image _ImageInput;

		private Pyramid _Pyramid;

		private Delay _PyramidDelay;

		private OpenVX.Array _KeypointsExemplar;

		private Delay _KeypointsDelay;

		#region Application Configuration

		uint    max_keypoint_count      = 10000;               // maximum number of keypoints to track
		float harris_strength_thresh  = 0.0005f;               // minimum corner strength to keep a corner
		float harris_min_distance     = 5.0f;                  // radial L2 distance for non-max suppression
		float harris_sensitivity      = 0.04f;                 // multiplier k in det(A) - k * trace(A)^2
		int   harris_gradient_size    = 3;                     // window size for gradient computation
		int   harris_block_size       = 3;                     // block window size for Harris corner score
		uint  lk_pyramid_levels       = 6;                     // number of pyramid levels for optical flow
		float lk_pyramid_scale        = VX.SCALE_PYRAMID_HALF; // pyramid levels scale by factor of two
		TerminationCriteria lk_termination = TerminationCriteria.Both; // iteration termination criteria (eps & iterations)
		float lk_epsilon              = 0.01f;                 // convergence criterion
		uint  lk_num_iterations       = 5;                     // maximum number of iterations
		bool    lk_use_initial_estimate = false;            // don't use initial estimate
		uint  lk_window_dimension     = 6;                     // window size for evaluation
		float trackable_kp_ratio_thr  = 0.8f;                  // threshold for the ration of tracked keypoints to all

		#endregion
	}
}
