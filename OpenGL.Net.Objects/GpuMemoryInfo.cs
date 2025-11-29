
namespace OpenGL.Objects
{
	/// <summary>
	/// GPU memory information.
	/// </summary>
	public sealed class GpuMemoryInfo
	{
		#region Information Query

		public static GpuMemoryInfo Query(GraphicsContext ctx)
		{
			GraphicsResource.CheckCurrentContext(ctx);

			if (ctx.Extensions.GpuMemoryInfo_NVX) {
				GpuMemoryInfo gpuMemoryInfo = new GpuMemoryInfo();

				Gl.Get(Gl.GPU_MEMORY_INFO_DEDICATED_VIDMEM_NVX, out gpuMemoryInfo.Dedicated);
				Gl.Get(Gl.GPU_MEMORY_INFO_TOTAL_AVAILABLE_MEMORY_NVX, out gpuMemoryInfo.TotalAvailable);
				Gl.Get(Gl.GPU_MEMORY_INFO_CURRENT_AVAILABLE_VIDMEM_NVX, out gpuMemoryInfo.CurrentAvailable);
				Gl.Get(Gl.GPU_MEMORY_INFO_EVICTION_COUNT_NVX, out gpuMemoryInfo.EvictionCount);
				Gl.Get(Gl.GPU_MEMORY_INFO_EVICTED_MEMORY_NVX, out gpuMemoryInfo.EvictedMemory);

				return gpuMemoryInfo;
			} else
				return null;
		}

		#endregion

		#region GPU Memory Information

		/// <summary>
		/// Dedicated video memory of the GPU memory, in kb.
		/// </summary>
		int Dedicated;

		/// <summary>
		/// Total available video memory of the GPU memory, in kb.
		/// </summary>
		int TotalAvailable;

		/// <summary>
		/// Current available video memory of the GPU memory, in kb.
		/// </summary>
		int CurrentAvailable;

		/// <summary>
		/// Count of total evictions seen by system.
		/// </summary>
		int EvictionCount;

		/// <summary>
		/// Size of the total video memory evicted, in kb.
		/// </summary>
		int EvictedMemory;

		#endregion

		#region Overrides

		public override string ToString()
		{
			return $"GPU Memory: {CurrentAvailable}/{TotalAvailable} [KB] (eviction: {EvictionCount}, {EvictedMemory} KB)";
		}

		#endregion
	}
}
