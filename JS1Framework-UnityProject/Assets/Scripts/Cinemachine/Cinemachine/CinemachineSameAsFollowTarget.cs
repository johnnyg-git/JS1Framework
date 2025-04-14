using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class CinemachineSameAsFollowTarget : CinemachineComponentBase
	{
		[Tooltip("How much time it takes for the aim to catch up to the target's rotation")]
		[FormerlySerializedAs("m_AngularDamping")]
		public float m_Damping;

		private Quaternion m_PreviousReferenceOrientation;

		public override bool IsValid => false;

		public override CinemachineCore.Stage Stage => default(CinemachineCore.Stage);

		public override float GetMaxDampTime()
		{
			return 0f;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
		}
	}
}
