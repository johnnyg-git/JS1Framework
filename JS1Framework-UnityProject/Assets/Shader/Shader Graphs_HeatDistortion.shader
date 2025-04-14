Shader "Shader Graphs/HeatDistortion" {
	Properties {
		_HeatDistortion ("HeatDistortion", Range(0, 0.5)) = 0
		_DistortionSpeed ("DistortionSpeed", Vector) = (0,-0.2,0,0)
		_Noise_Tile ("Noise Tile", Vector) = (1,1,0,0)
		_Noise_Strength ("Noise Strength", Float) = 1
		_Depth_Fade_Length ("Depth Fade Length", Float) = 0.01
		[NoScaleOffset] _Distortion_Texture ("Distortion Texture", 2D) = "white" {}
		_Distortion_Mask_Contrast ("Distortion Mask Contrast", Range(0, 1)) = 0.5
		_Distortion_Mask_Radius ("Distortion Mask Radius", Range(-1, 1)) = -0.08
		[HideInInspector] _QueueOffset ("_QueueOffset", Float) = 0
		[HideInInspector] _QueueControl ("_QueueControl", Float) = -1
		[HideInInspector] [NoScaleOffset] unity_Lightmaps ("unity_Lightmaps", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_LightmapsInd ("unity_LightmapsInd", 2DArray) = "" {}
		[HideInInspector] [NoScaleOffset] unity_ShadowMasks ("unity_ShadowMasks", 2DArray) = "" {}
		[HideInInspector] _BUILTIN_QueueOffset ("Float", Float) = 0
		[HideInInspector] _BUILTIN_QueueControl ("Float", Float) = -1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	Fallback "Hidden/Shader Graph/FallbackError"
	//CustomEditor "UnityEditor.ShaderGraph.GenericShaderGraphMaterialGUI"
}