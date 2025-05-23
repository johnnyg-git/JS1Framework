using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1103)]
	public struct UserAchievementStored_t
	{
		public const int k_iCallback = 1103;

		public ulong m_nGameID;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bGroupAchievement;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_rgchAchievementName_;

		public uint m_nCurProgress;

		public uint m_nMaxProgress;

		public string m_rgchAchievementName
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
