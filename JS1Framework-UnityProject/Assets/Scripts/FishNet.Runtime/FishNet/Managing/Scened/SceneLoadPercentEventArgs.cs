namespace FishNet.Managing.Scened
{
	public struct SceneLoadPercentEventArgs
	{
		public readonly LoadQueueData QueueData;

		public readonly float Percent;

		internal SceneLoadPercentEventArgs(LoadQueueData lqd, float percent)
		{
			QueueData = null;
			Percent = 0f;
		}
	}
}
