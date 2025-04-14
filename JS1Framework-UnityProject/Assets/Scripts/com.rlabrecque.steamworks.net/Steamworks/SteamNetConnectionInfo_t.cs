using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamNetConnectionInfo_t
	{
		public SteamNetworkingIdentity m_identityRemote;

		public long m_nUserData;

		public HSteamListenSocket m_hListenSocket;

		public SteamNetworkingIPAddr m_addrRemote;

		public ushort m__pad1;

		public SteamNetworkingPOPID m_idPOPRemote;

		public SteamNetworkingPOPID m_idPOPRelay;

		public ESteamNetworkingConnectionState m_eState;

		public int m_eEndReason;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_szEndDebug_;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_szConnectionDescription_;

		public int m_nFlags;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 63)]
		public uint[] reserved;

		public string m_szEndDebug
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_szConnectionDescription
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
