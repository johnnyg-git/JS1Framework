using ScheduleOne.UI.Shop;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Herbert : NPC
	{
		public ShopInterface ShopInterface;

		[Header("Settings")]
		public string[] OrderCompletedLines;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EHerbertAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EHerbertAssembly_002DCSharp_002Edll_Excuted;

		protected override void Start()
		{
		}

		private void OrderCompleted()
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
