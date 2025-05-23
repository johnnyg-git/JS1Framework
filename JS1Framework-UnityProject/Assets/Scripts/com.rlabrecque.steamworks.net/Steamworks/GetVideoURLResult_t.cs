using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4611)]
	public struct GetVideoURLResult_t
	{
		public const int k_iCallback = 4611;

		public EResult m_eResult;

		public AppId_t m_unVideoAppID;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		private byte[] m_rgchURL_;

		public string m_rgchURL
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
