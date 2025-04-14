using System;
using FishNet.Transporting;
using UnityEngine;

namespace FishNet.Object.Synchronizing
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class SyncVarAttribute : PropertyAttribute
	{
		public float SendRate;

		public ReadPermission ReadPermissions;

		public WritePermission WritePermissions;

		public Channel Channel;

		public string OnChange;
	}
}
