using EasyButtons;

namespace ScheduleOne.NPCs.Schedules
{
	public class NPCEvent : NPCAction
	{
		public int Duration;

		public int EndTime;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCEventAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCEventAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		[Button]
		public void ApplyDuration()
		{
		}

		[Button]
		public void ApplyEndTime()
		{
		}

		public override void ActiveMinPassed()
		{
		}

		public override void PendingMinPassed()
		{
		}

		public override string GetName()
		{
			return null;
		}

		public override string GetTimeDescription()
		{
			return null;
		}

		public override int GetEndTime()
		{
			return 0;
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
