using System;

namespace FishNet.Transporting
{
	public struct ClientReceivedDataArgs
	{
		public ArraySegment<byte> Data;

		public Channel Channel;

		public int TransportIndex;

		public ClientReceivedDataArgs(ArraySegment<byte> data, Channel channel, int transportIndex)
		{
			Data = default(ArraySegment<byte>);
			Channel = default(Channel);
			TransportIndex = 0;
		}
	}
}
