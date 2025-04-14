using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(165)]
	public struct StoreAuthURLResponse_t
	{
		public const int k_iCallback = 165;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
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
