using ScheduleOne.DevUtilities;
using ScheduleOne.Dialogue;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Marco : NPC
	{
		public Transform VehicleRecoveryPoint;

		public VehicleDetector VehicleDetector;

		public DialogueContainer RecoveryConversation;

		public DialogueContainer GreetingDialogue;

		public string GreetedVariable;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EMarcoAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EMarcoAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private bool ShouldShowRecoverVehicle(bool enabled)
		{
			return false;
		}

		private bool RecoverVehicleValid(out string reason)
		{
			reason = null;
			return false;
		}

		private bool RepaintVehicleValid(out string reason)
		{
			reason = null;
			return false;
		}

		private void RecoverVehicle()
		{
		}

		private void Loaded()
		{
		}

		private void EnableGreeting()
		{
		}

		private void SetGreeted()
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ECharacterClasses_002EMarco_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
