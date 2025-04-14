using UnityEngine;

namespace ScheduleOne.NPCs.Behaviour
{
	public class UnconsciousBehaviour : Behaviour
	{
		public const float SnoreInterval = 6f;

		public ParticleSystem Particles;

		public bool PlaySnoreSounds;

		private float timeOnLastSnore;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EUnconsciousBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EUnconsciousBehaviourAssembly_002DCSharp_002Edll_Excuted;

		protected override void Begin()
		{
		}

		protected override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		public override void Disable()
		{
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
