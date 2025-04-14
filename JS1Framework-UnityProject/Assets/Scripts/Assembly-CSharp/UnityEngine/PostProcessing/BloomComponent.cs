namespace UnityEngine.PostProcessing
{
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		private static class Uniforms
		{
			internal static readonly int _AutoExposure;

			internal static readonly int _Threshold;

			internal static readonly int _Curve;

			internal static readonly int _PrefilterOffs;

			internal static readonly int _SampleScale;

			internal static readonly int _BaseTex;

			internal static readonly int _BloomTex;

			internal static readonly int _Bloom_Settings;

			internal static readonly int _Bloom_DirtTex;

			internal static readonly int _Bloom_DirtIntensity;
		}

		private const int k_MaxPyramidBlurLevel = 16;

		private readonly RenderTexture[] m_BlurBuffer1;

		private readonly RenderTexture[] m_BlurBuffer2;

		public override bool active => false;

		public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
		}
	}
}
