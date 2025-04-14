using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	[SaveDuringPlay]
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineFollowZoom.html")]
	public class CinemachineFollowZoom : CinemachineExtension
	{
		private class VcamExtraState
		{
			public float m_previousFrameZoom;
		}

		[Tooltip("The shot width to maintain, in world units, at target distance.")]
		public float m_Width;

		[Range(0f, 20f)]
		[Tooltip("Increase this value to soften the aggressiveness of the follow-zoom.  Small numbers are more responsive, larger numbers give a more heavy slowly responding camera.")]
		public float m_Damping;

		[Range(1f, 179f)]
		[Tooltip("Lower limit for the FOV that this behaviour will generate.")]
		public float m_MinFOV;

		[Range(1f, 179f)]
		[Tooltip("Upper limit for the FOV that this behaviour will generate.")]
		public float m_MaxFOV;

		private void OnValidate()
		{
		}

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}
	}
}
