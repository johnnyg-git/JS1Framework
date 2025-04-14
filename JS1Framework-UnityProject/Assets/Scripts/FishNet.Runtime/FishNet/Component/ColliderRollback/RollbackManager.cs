using System;
using System.Runtime.CompilerServices;
using FishNet.Managing;
using FishNet.Managing.Timing;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace FishNet.Component.ColliderRollback
{
	public class RollbackManager : MonoBehaviour
	{
		[Serializable]
		[Flags]
		public enum PhysicsType : byte
		{
			TwoDimensional = 1,
			ThreeDimensional = 2,
			Both = 4
		}

		private int? _boundingBoxLayerNumber;

		[Tooltip("Layer to use when creating and checking against bounding boxes. This should be different from any layer used.")]
		[SerializeField]
		private LayerMask _boundingBoxLayer;

		[Tooltip("Maximum time in the past colliders can be rolled back to.")]
		[SerializeField]
		private float _maximumRollbackTime;

		[Tooltip("Interpolation value for the NetworkTransforms or objects being rolled back.")]
		[Range(0f, 250f)]
		[SerializeField]
		internal ushort Interpolation;

		internal int? BoundingBoxLayerNumber => null;

		internal LayerMask BoundingBoxLayer => default(LayerMask);

		internal float MaximumRollbackTime => 0f;

		internal void InitializeOnce_Internal(NetworkManager manager)
		{
		}

		[Obsolete("Use Rollback(PreciseTick, RollbackPhysicsType, bool)")]
		public void Rollback(PreciseTick pt, PhysicsType physicsType, bool asOwner = false)
		{
		}

		public void Rollback(PreciseTick pt, RollbackPhysicsType physicsType, bool asOwner = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Rollback(Scene scene, PreciseTick pt, RollbackPhysicsType physicsType, bool asOwner = false)
		{
		}

		public void Rollback(int sceneHandle, PreciseTick pt, RollbackPhysicsType physicsType, bool asOwner = false)
		{
		}

		public void Rollback(Vector3 origin, Vector3 normalizedDirection, float distance, PreciseTick pt, bool asOwner = false)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Rollback(Scene scene, Vector3 origin, Vector3 normalizedDirection, float distance, PreciseTick pt, bool asOwner = false)
		{
		}

		public void Rollback(int sceneHandle, Vector3 origin, Vector3 normalizedDirection, float distance, PreciseTick pt, bool asOwner = false)
		{
		}

		public void Rollback(Vector2 origin, Vector2 normalizedDirection, float distance, PreciseTick pt, bool asOwner = false)
		{
		}

		public void Return()
		{
		}
	}
}
