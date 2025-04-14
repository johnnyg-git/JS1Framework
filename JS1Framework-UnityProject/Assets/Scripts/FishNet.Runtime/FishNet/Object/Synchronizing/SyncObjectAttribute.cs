using System;
using UnityEngine;

namespace FishNet.Object.Synchronizing
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class SyncObjectAttribute : PropertyAttribute
	{
		public float SendRate;

		public ReadPermission ReadPermissions;

		public WritePermission WritePermissions;

		public bool RequireReadOnly;
	}
}
