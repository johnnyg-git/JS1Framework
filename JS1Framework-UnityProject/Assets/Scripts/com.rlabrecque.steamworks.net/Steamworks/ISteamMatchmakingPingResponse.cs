using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class ISteamMatchmakingPingResponse
	{
		public delegate void ServerResponded(gameserveritem_t server);

		public delegate void ServerFailedToRespond();

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, gameserveritem_t server);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		public ISteamMatchmakingPingResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond)
		{
		}

		~ISteamMatchmakingPingResponse()
		{
		}

		private void InternalOnServerResponded(IntPtr thisptr, gameserveritem_t server)
		{
		}

		private void InternalOnServerFailedToRespond(IntPtr thisptr)
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingPingResponse that)
		{
			return (IntPtr)0;
		}
	}
}
