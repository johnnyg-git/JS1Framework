using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Product;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.NPCs.Behaviour
{
	public class ConsumeProductBehaviour : Behaviour
	{
		public AvatarEquippable JointPrefab;

		public AvatarEquippable PipePrefab;

		private ProductItemInstance product;

		private Coroutine consumeRoutine;

		public AudioSourceController WeedConsumeSound;

		public AudioSourceController MethConsumeSound;

		public AudioSourceController SnortSound;

		public ParticleSystem SmokeExhaleParticles;

		[Header("Debug")]
		public ProductDefinition TestProduct;

		public UnityEvent onConsumeDone;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EConsumeProductBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EConsumeProductBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public ProductItemInstance ConsumedProduct { get; private set; }

		protected virtual void Start()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendProduct(ProductItemInstance _product)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetProduct(ProductItemInstance _product)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void ClearEffects()
		{
		}

		protected override void Begin()
		{
		}

		protected override void Resume()
		{
		}

		private void TryConsume()
		{
		}

		public override void Disable()
		{
		}

		protected override void End()
		{
		}

		private void ConsumeWeed()
		{
		}

		private void ConsumeMeth()
		{
		}

		private void ConsumeCocaine()
		{
		}

		[ObserversRpc]
		private void ApplyEffects()
		{
		}

		private void Clear()
		{
		}

		private void DayPass(int minsSlept)
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

		private void RpcWriter___Server_SendProduct_2622925554(ProductItemInstance _product)
		{
		}

		public void RpcLogic___SendProduct_2622925554(ProductItemInstance _product)
		{
		}

		private void RpcReader___Server_SendProduct_2622925554(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProduct_2622925554(ProductItemInstance _product)
		{
		}

		public void RpcLogic___SetProduct_2622925554(ProductItemInstance _product)
		{
		}

		private void RpcReader___Observers_SetProduct_2622925554(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ClearEffects_2166136261()
		{
		}

		public void RpcLogic___ClearEffects_2166136261()
		{
		}

		private void RpcReader___Observers_ClearEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ApplyEffects_2166136261()
		{
		}

		private void RpcLogic___ApplyEffects_2166136261()
		{
		}

		private void RpcReader___Observers_ApplyEffects_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
