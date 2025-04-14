namespace ScheduleOne.NPCs.Behaviour
{
	public class FootPatrolBehaviour : Behaviour
	{
		public const float MOVE_SPEED = 0.08f;

		public const int FLASHLIGHT_MIN_TIME = 1930;

		public int FLASHLIGHT_MAX_TIME;

		public const string FLASHLIGHT_ASSET_PATH = "Tools/Flashlight/Flashlight_AvatarEquippable";

		public bool UseFlashlight;

		private bool flashlightEquipped;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EFootPatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EFootPatrolBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public PatrolGroup Group { get; protected set; }

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		protected override void Pause()
		{
		}

		protected override void End()
		{
		}

		public override void ActiveMinPass()
		{
		}

		private void SetFlashlightEquipped(bool equipped)
		{
		}

		public void SetGroup(PatrolGroup group)
		{
		}

		public bool IsReadyToAdvance()
		{
			return false;
		}

		private bool IsAtDestination()
		{
			return false;
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
