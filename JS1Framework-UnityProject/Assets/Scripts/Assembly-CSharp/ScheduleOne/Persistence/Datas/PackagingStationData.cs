using System;
using ScheduleOne.ItemFramework;
using ScheduleOne.Tiles;
using Grid = ScheduleOne.Tiles.Grid;
using UnityEngine;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class PackagingStationData : GridItemData
	{
		public ItemSet Contents;

		public PackagingStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet contents)
			: base(default(Guid), null, 0, null, default(Vector2), 0)
		{
		}
	}
}
