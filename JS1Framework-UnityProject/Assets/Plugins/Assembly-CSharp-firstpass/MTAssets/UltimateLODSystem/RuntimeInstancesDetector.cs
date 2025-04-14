using System.Collections.Generic;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	[AddComponentMenu("")]
	public class RuntimeInstancesDetector : MonoBehaviour
	{
		[HideInInspector]
		public List<UltimateLevelOfDetail> instancesOfUlodInThisScene;

		[HideInInspector]
		public List<UltimateLevelOfDetailOptimizer> instancesOfUlodOptimizerInThisScene;

		public void RegisterNewUlodOptimizerInThisScene(UltimateLevelOfDetailOptimizer optimizer)
		{
		}
	}
}
