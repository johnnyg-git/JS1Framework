using UnityEngine;

namespace Cinemachine
{
	[AddComponentMenu("")]
	[ExecuteAlways]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	public class Cinemachine3rdPersonAim : CinemachineExtension
	{
		[Header("Aim Target Detection")]
		[Tooltip("Objects on these layers will be detected")]
		public LayerMask AimCollisionFilter;

		[TagField]
		[Tooltip("Objects with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string IgnoreTag;

		[Tooltip("How far to project the object detection ray")]
		public float AimDistance;

		[Tooltip("This 2D object will be positioned in the game view over the raycast hit point, if any, or will remain in the center of the screen if no hit point is detected.  May be null, in which case no on-screen indicator will appear")]
		public RectTransform AimTargetReticle;

		public Vector3 AimTarget { get; private set; }

		private void OnValidate()
		{
		}

		private void Reset()
		{
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			return false;
		}

		private void DrawReticle(CinemachineBrain brain)
		{
		}

		private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player)
		{
			return default(Vector3);
		}

		private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player)
		{
			return default(Vector3);
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}
	}
}
