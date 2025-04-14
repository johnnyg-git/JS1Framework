using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class ISteamMatchmakingServerListResponse
	{
		public delegate void ServerResponded(HServerListRequest hRequest, int iServer);

		public delegate void ServerFailedToRespond(HServerListRequest hRequest, int iServer);

		public delegate void RefreshComplete(HServerListRequest hRequest, EMatchMakingServerResponse response);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		private delegate void InternalRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerResponded m_VTServerResponded;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalServerFailedToRespond m_VTServerFailedToRespond;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalRefreshComplete m_VTRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private ServerResponded m_ServerResponded;

		private ServerFailedToRespond m_ServerFailedToRespond;

		private RefreshComplete m_RefreshComplete;

		public ISteamMatchmakingServerListResponse(ServerResponded onServerResponded, ServerFailedToRespond onServerFailedToRespond, RefreshComplete onRefreshComplete)
		{
		}

		~ISteamMatchmakingServerListResponse()
		{
		}

		private void InternalOnServerResponded(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		private void InternalOnServerFailedToRespond(IntPtr thisptr, HServerListRequest hRequest, int iServer)
		{
		}

		private void InternalOnRefreshComplete(IntPtr thisptr, HServerListRequest hRequest, EMatchMakingServerResponse response)
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingServerListResponse that)
		{
			return (IntPtr)0;
		}
	}
}
