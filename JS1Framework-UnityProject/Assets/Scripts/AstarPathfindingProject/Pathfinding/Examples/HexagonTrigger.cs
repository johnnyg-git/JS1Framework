using UnityEngine;
using UnityEngine.UI;

namespace Pathfinding.Examples
{
	[RequireComponent(typeof(Animator))]
	[HelpURL("http://arongranberg.com/astar/documentation/stable/class_pathfinding_1_1_examples_1_1_hexagon_trigger.php")]
	public class HexagonTrigger : MonoBehaviour
	{
		public Button button;

		private Animator anim;

		private bool visible;

		private void Awake()
		{
		}

		private void OnTriggerEnter(Collider coll)
		{
		}

		private void OnTriggerExit(Collider coll)
		{
		}
	}
}
