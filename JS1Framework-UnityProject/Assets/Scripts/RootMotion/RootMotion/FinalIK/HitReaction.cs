using System;
using UnityEngine;

namespace RootMotion.FinalIK
{
	public class HitReaction : OffsetModifier
	{
		[Serializable]
		public abstract class HitPoint
		{
			[Tooltip("Just for visual clarity, not used at all")]
			public string name;

			[Tooltip("Linking this hit point to a collider")]
			public Collider collider;

			[Tooltip("Only used if this hit point gets hit when already processing another hit")]
			[SerializeField]
			private float crossFadeTime;

			private float length;

			private float crossFadeSpeed;

			private float lastTime;

			public bool inProgress => false;

			protected float crossFader { get; private set; }

			protected float timer { get; private set; }

			protected Vector3 force { get; private set; }

			public virtual void Hit(Vector3 force, Vector3 point)
			{
			}

			public void Apply(IKSolverFullBodyBiped solver, float weight)
			{
			}

			protected abstract float GetLength();

			protected abstract void CrossFadeStart();

			protected abstract void OnApply(IKSolverFullBodyBiped solver, float weight);
		}

		[Serializable]
		public class HitPointEffector : HitPoint
		{
			[Serializable]
			public class EffectorLink
			{
				[Tooltip("The FBBIK effector type")]
				public FullBodyBipedEffector effector;

				[Tooltip("The weight of this effector (could also be negative)")]
				public float weight;

				private Vector3 lastValue;

				private Vector3 current;

				public void Apply(IKSolverFullBodyBiped solver, Vector3 offset, float crossFader)
				{
				}

				public void CrossFadeStart()
				{
				}
			}

			[Tooltip("Offset magnitude in the direction of the hit force")]
			public AnimationCurve offsetInForceDirection;

			[Tooltip("Offset magnitude in the direction of character.up")]
			public AnimationCurve offsetInUpDirection;

			[Tooltip("Linking this offset to the FBBIK effectors")]
			public EffectorLink[] effectorLinks;

			protected override float GetLength()
			{
				return 0f;
			}

			protected override void CrossFadeStart()
			{
			}

			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}
		}

		[Serializable]
		public class HitPointBone : HitPoint
		{
			[Serializable]
			public class BoneLink
			{
				[Tooltip("Reference to the bone that this hit point rotates")]
				public Transform bone;

				[Tooltip("Weight of rotating the bone")]
				[Range(0f, 1f)]
				public float weight;

				private Quaternion lastValue;

				private Quaternion current;

				public void Apply(IKSolverFullBodyBiped solver, Quaternion offset, float crossFader)
				{
				}

				public void CrossFadeStart()
				{
				}
			}

			[Tooltip("The angle to rotate the bone around its rigidbody's world center of mass")]
			public AnimationCurve aroundCenterOfMass;

			[Tooltip("Linking this hit point to bone(s)")]
			public BoneLink[] boneLinks;

			private Rigidbody rigidbody;

			private Vector3 comAxis;

			public override void Hit(Vector3 force, Vector3 point)
			{
			}

			protected override float GetLength()
			{
				return 0f;
			}

			protected override void CrossFadeStart()
			{
			}

			protected override void OnApply(IKSolverFullBodyBiped solver, float weight)
			{
			}
		}

		[Tooltip("Hit points for the FBBIK effectors")]
		public HitPointEffector[] effectorHitPoints;

		[Tooltip(" Hit points for bones without an effector, such as the head")]
		public HitPointBone[] boneHitPoints;

		public bool inProgress => false;

		protected override void OnModifyOffset()
		{
		}

		public void Hit(Collider collider, Vector3 force, Vector3 point)
		{
		}
	}
}
