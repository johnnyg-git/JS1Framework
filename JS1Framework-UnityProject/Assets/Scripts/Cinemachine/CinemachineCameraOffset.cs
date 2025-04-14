using Cinemachine;
using UnityEngine;

[AddComponentMenu("")]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/api/Cinemachine.CinemachineCameraOffset.html")]
[SaveDuringPlay]
public class CinemachineCameraOffset : CinemachineExtension
{
	[Tooltip("Offset the camera's position by this much (camera space)")]
	public Vector3 m_Offset;

	[Tooltip("When to apply the offset")]
	public CinemachineCore.Stage m_ApplyAfter;

	[Tooltip("If applying offset after aim, re-adjust the aim to preserve the screen position of the LookAt target as much as possible")]
	public bool m_PreserveComposition;

	protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
	{
	}
}
