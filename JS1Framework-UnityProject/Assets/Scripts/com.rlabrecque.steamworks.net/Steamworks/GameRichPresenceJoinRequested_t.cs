using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(337)]
	public struct GameRichPresenceJoinRequested_t
	{
		public const int k_iCallback = 337;

		public CSteamID m_steamIDFriend;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		private byte[] m_rgchConnect_;

		public string m_rgchConnect
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
