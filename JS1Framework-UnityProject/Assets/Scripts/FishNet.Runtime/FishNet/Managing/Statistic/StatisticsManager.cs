using UnityEngine;

namespace FishNet.Managing.Statistic
{
	[DisallowMultipleComponent]
	[AddComponentMenu("FishNet/Manager/StatisticsManager")]
	public class StatisticsManager : MonoBehaviour
	{
		public NetworkTraficStatistics NetworkTraffic;

		internal void InitializeOnce_Internal(NetworkManager manager)
		{
		}
	}
}
