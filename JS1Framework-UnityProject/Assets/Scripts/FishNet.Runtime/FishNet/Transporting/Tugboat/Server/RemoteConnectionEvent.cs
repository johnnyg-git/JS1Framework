namespace FishNet.Transporting.Tugboat.Server
{
	internal struct RemoteConnectionEvent
	{
		public readonly bool Connected;

		public readonly int ConnectionId;

		public RemoteConnectionEvent(bool connected, int connectionId)
		{
			Connected = false;
			ConnectionId = 0;
		}
	}
}
