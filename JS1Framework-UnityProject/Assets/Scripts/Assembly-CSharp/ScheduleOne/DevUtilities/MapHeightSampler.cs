using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	public class MapHeightSampler
	{
		private static float SampleHeight;

		private static float SampleDistance;

		public static Vector3 ResetPosition;

		public static bool Sample(float x, out float y, float z)
		{
			y = default(float);
			return false;
		}
	}
}
