using System;
using ScheduleOne.Tiles;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Storage
{
	[Serializable]
	public struct CoordinateStorageTilePair
	{
		public Coordinate coord;

		public StorageTile tile;
	}
}
