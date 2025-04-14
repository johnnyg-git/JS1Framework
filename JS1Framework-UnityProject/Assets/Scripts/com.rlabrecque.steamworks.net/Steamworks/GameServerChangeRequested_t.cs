using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(332)]
	public struct GameServerChangeRequested_t
	{
		public const int k_iCallback = 332;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_rgchServer_;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_rgchPassword_;

		public string m_rgchServer
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string m_rgchPassword
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
