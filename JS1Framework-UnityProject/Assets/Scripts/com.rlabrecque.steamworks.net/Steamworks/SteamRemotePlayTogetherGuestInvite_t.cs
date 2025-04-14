using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(5703)]
	public struct SteamRemotePlayTogetherGuestInvite_t
	{
		public const int k_iCallback = 5703;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
		private byte[] m_szConnectURL_;

		public string m_szConnectURL
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
