using System.Collections.Generic;
using FishNet.Documenting;
using FishNet.Object;
using UnityEngine;

namespace FishNet.Managing.Object
{
	[APIExclude]
	public abstract class PrefabObjects : ScriptableObject
	{
		public ushort CollectionId { get; private set; }

		internal void SetCollectionId(ushort id)
		{
		}

		public abstract void Clear();

		public abstract int GetObjectCount();

		public abstract NetworkObject GetObject(bool asServer, int id);

		public abstract void RemoveNull();

		public abstract void AddObject(NetworkObject networkObject, bool checkForDuplicates = false);

		public abstract void AddObjects(List<NetworkObject> networkObjects, bool checkForDuplicates = false);

		public abstract void AddObjects(NetworkObject[] networkObjects, bool checkForDuplicates = false);

		public abstract void AddObject(DualPrefab dualPrefab, bool checkForDuplicates = false);

		public abstract void AddObjects(List<DualPrefab> dualPrefab, bool checkForDuplicates = false);

		public abstract void AddObjects(DualPrefab[] dualPrefab, bool checkForDuplicates = false);

		public abstract void InitializePrefabRange(int startIndex);
	}
}
