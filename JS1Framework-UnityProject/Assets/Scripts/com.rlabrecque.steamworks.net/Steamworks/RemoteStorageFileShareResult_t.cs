using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1307)]
	public struct RemoteStorageFileShareResult_t
	{
		public const int k_iCallback = 1307;

		public EResult m_eResult;

		public UGCHandle_t m_hFile;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
		private byte[] m_rgchFilename_;

		public string m_rgchFilename
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
