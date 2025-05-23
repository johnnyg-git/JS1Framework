using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1317)]
	public struct RemoteStorageDownloadUGCResult_t
	{
		public const int k_iCallback = 1317;

		public EResult m_eResult;

		public UGCHandle_t m_hFile;

		public AppId_t m_nAppID;

		public int m_nSizeInBytes;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
		private byte[] m_pchFileName_;

		public ulong m_ulSteamIDOwner;

		public string m_pchFileName
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
