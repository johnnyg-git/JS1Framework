using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(349)]
	public struct OverlayBrowserProtocolNavigation_t
	{
		public const int k_iCallback = 349;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
		private byte[] rgchURI_;

		public string rgchURI
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
