using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Schedules
{
	public class NPCEvent_LocationBasedAction : NPCEvent
	{
		public Transform Destination;

		public bool FaceDestinationDir;

		public float DestinationThreshold;

		public bool WarpIfSkipped;

		public bool IsActionStarted;

		public UnityEvent onStartAction;

		public UnityEvent onEndAction;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_LocationBasedActionAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ESchedules_002ENPCEvent_LocationBasedActionAssembly_002DCSharp_002Edll_Excuted;

		public new string ActionName => null;

		public override string GetName()
		{
			return null;
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public override void Started()
		{
		}

		public override void ActiveMinPassed()
		{
		}

		public override void LateStarted()
		{
		}

		public override void JumpTo()
		{
		}

		public override void End()
		{
		}

		public override void Interrupt()
		{
		}

		public override void Resume()
		{
		}

		public override void Skipped()
		{
		}

		private bool IsAtDestination()
		{
			return false;
		}

		protected override void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected virtual void StartAction(NetworkConnection conn)
		{
		}

		[ObserversRpc(RunLocally = true)]
		protected virtual void EndAction()
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

		private void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn)
		{
		}

		protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_StartAction_328543758(NetworkConnection conn)
		{
		}

		private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EndAction_2166136261()
		{
		}

		protected virtual void RpcLogic___EndAction_2166136261()
		{
		}

		private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
