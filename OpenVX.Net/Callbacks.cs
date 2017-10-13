using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenVX
{
	public delegate void PublishKernelsCallback();

	public delegate void UnpublishKernelsCallback();

	public delegate void KernelCallback();

	public delegate void KernelInitializeCallback();

	public delegate void KernelDeinitializeCallback();

	public delegate void KernelValidateCallbackCallback();

	public delegate void KernelImageValidRectangleCallback();

	public delegate void LogCallback();

	public delegate void NodeCompleteCallback();
}
