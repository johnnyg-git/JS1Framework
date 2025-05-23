using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(206)]
	public struct GSClientAchievementStatus_t
	{
		public const int k_iCallback = 206;

		public ulong m_SteamID;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_pchAchievement_;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUnlocked;

		public string m_pchAchievement
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
