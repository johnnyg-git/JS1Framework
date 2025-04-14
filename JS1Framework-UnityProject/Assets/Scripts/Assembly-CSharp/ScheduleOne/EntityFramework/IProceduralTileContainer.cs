using System.Collections.Generic;
using ScheduleOne.Tiles;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.EntityFramework
{
	public interface IProceduralTileContainer
	{
		List<ProceduralTile> ProceduralTiles { get; }
	}
}
