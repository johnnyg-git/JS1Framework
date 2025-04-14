using System;
using ScheduleOne.Tiles;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Storage
{
	[Serializable]
	public struct CoordinateStorageFootprintTilePair
	{
		public Coordinate coord;

		public FootprintTile tile;
	}
}
