using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Managing;
using UnityEngine;

namespace FishNet.Transporting.Multipass
{
	[AddComponentMenu("FishNet/Transport/Multipass")]
	public class Multipass : Transport
	{
		public struct ClientTransportData : IEquatable<ClientTransportData>
		{
			public int TransportIndex;

			public int TransportId;

			public int MultipassId;

			private int _hashCode;

			public ClientTransportData(int transportIndex, int transportId, int multipassId)
			{
				TransportIndex = 0;
				TransportId = 0;
				MultipassId = 0;
				_hashCode = 0;
			}

			public bool Equals(ClientTransportData other)
			{
				return false;
			}
		}

		[Tooltip("While true server actions such as starting or stopping the server will run on all transport.")]
		public bool GlobalServerActions;

		private Transport _clientTransport;

		[Tooltip("Transports to use.")]
		[SerializeField]
		private List<Transport> _transports;

		private readonly ClientTransportData INVALID_CLIENTTRANSPORTDATA;

		private Dictionary<int, ClientTransportData> _multpassIdLookup;

		private List<Dictionary<int, ClientTransportData>> _transportIdLookup;

		private Queue<int> _availableMultipassIds;

		internal const int CLIENT_HOST_ID = 32767;

		[HideInInspector]
		public Transport ClientTransport
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public IList<Transport> Transports => null;

		public override event Action<ClientConnectionStateArgs> OnClientConnectionState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<ServerConnectionStateArgs> OnServerConnectionState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<RemoteConnectionStateArgs> OnRemoteConnectionState
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<ClientReceivedDataArgs> OnClientReceivedData
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override event Action<ServerReceivedDataArgs> OnServerReceivedData
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public override void Initialize(NetworkManager networkManager, int transportIndex)
		{
		}

		private void OnDestroy()
		{
		}

		private void ResetLookupCollections()
		{
		}

		private void TryResetClientIds(bool force)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ClientTransportData GetDataFromTransportId(int transportIndex, int transportId)
		{
			return default(ClientTransportData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ClientTransportData GetDataFromMultipassId(int multipassId)
		{
			return default(ClientTransportData);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override string GetConnectionAddress(int multipassId)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override LocalConnectionState GetConnectionState(bool server)
		{
			return default(LocalConnectionState);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public LocalConnectionState GetConnectionState(bool server, int transportIndex)
		{
			return default(LocalConnectionState);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override RemoteConnectionState GetConnectionState(int multipassId)
		{
			return default(RemoteConnectionState);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public RemoteConnectionState GetConnectionState(int connectionId, int index)
		{
			return default(RemoteConnectionState);
		}

		private void Multipass_OnClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
		}

		private void Multipass_OnServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
		}

		private void Multipass_OnRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
		}

		public override void IterateIncoming(bool server)
		{
		}

		public override void IterateOutgoing(bool server)
		{
		}

		private void Multipass_OnClientReceivedData(ClientReceivedDataArgs receivedDataArgs)
		{
		}

		private void Multipass_OnServerReceivedData(ServerReceivedDataArgs receivedDataArgs)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void SendToServer(byte channelId, ArraySegment<byte> segment)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void SendToClient(byte channelId, ArraySegment<byte> segment, int multipassId)
		{
		}

		private bool UseGlobalServerActionsWithError(string methodText)
		{
			return false;
		}

		private bool IsClientTransportSetWithError(string methodText)
		{
			return false;
		}

		private void CreateAvailableIds()
		{
		}

		public void SetClientTransport<T>()
		{
		}

		public void SetClientTransport(Type type)
		{
		}

		public void SetClientTransport(Transport transport)
		{
		}

		public void SetClientTransport(int index)
		{
		}

		public Transport GetTransport(int index)
		{
			return null;
		}

		public T GetTransport<T>()
		{
			return default(T);
		}

		public override bool IsLocalTransport(int multipassId)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int GetMaximumClients()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int GetMaximumClients(int transportIndex)
		{
			return 0;
		}

		public override void SetMaximumClients(int value)
		{
		}

		public void SetMaximumClients(int value, int transportIndex)
		{
		}

		public override void SetClientAddress(string address)
		{
		}

		public override void SetServerBindAddress(string address, IPAddressType addressType)
		{
		}

		public void SetServerBindAddress(string address, IPAddressType addressType, int index)
		{
		}

		public override void SetPort(ushort port)
		{
		}

		public void SetPort(ushort port, int index)
		{
		}

		public override bool StartConnection(bool server)
		{
			return false;
		}

		public bool StartConnection(bool server, int index)
		{
			return false;
		}

		public override bool StopConnection(bool server)
		{
			return false;
		}

		public bool StopConnection(bool server, int index)
		{
			return false;
		}

		public override bool StopConnection(int connectionId, bool immediately)
		{
			return false;
		}

		public bool StopServerConnection(bool sendDisconnectMessage, int transportIndex)
		{
			return false;
		}

		public override void Shutdown()
		{
		}

		private bool StartServer(int index)
		{
			return false;
		}

		private bool StopServer(int index)
		{
			return false;
		}

		private bool StartClient()
		{
			return false;
		}

		private bool StopClient()
		{
			return false;
		}

		private bool StopClient(int multipassId, bool immediately)
		{
			return false;
		}

		public override int GetMTU(byte channel)
		{
			return 0;
		}

		public int GetMTU(byte channel, int index)
		{
			return 0;
		}

		private bool IndexInRange(int index, bool error)
		{
			return false;
		}

		public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs)
		{
		}

		public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs)
		{
		}

		public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs)
		{
		}

		public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs)
		{
		}

		public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs)
		{
		}
	}
}
