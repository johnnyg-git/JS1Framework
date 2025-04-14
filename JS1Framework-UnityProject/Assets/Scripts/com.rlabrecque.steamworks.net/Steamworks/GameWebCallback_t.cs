using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(164)]
	public struct GameWebCallback_t
	{
		public const int k_iCallback = 164;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
		private byte[] m_szURL_;

		public string m_szURL
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
