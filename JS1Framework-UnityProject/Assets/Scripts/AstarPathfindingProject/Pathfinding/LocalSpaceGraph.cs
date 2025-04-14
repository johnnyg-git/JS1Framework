using Pathfinding.Util;
using UnityEngine;

namespace Pathfinding
{
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_local_space_graph.php")]
	public class LocalSpaceGraph : VersionedMonoBehaviour
	{
		private Matrix4x4 originalMatrix;

		public GraphTransform transformation { get; private set; }

		private void Start()
		{
		}

		public void Refresh()
		{
		}
	}
}
