using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public class ISteamMatchmakingPlayersResponse
	{
		public delegate void AddPlayerToList(string pchName, int nScore, float flTimePlayed);

		public delegate void PlayersFailedToRespond();

		public delegate void PlayersRefreshComplete();

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersFailedToRespond(IntPtr thisptr);

		[UnmanagedFunctionPointer(CallingConvention.ThisCall)]
		public delegate void InternalPlayersRefreshComplete(IntPtr thisptr);

		[StructLayout(LayoutKind.Sequential)]
		private class VTable
		{
			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalAddPlayerToList m_VTAddPlayerToList;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalPlayersFailedToRespond m_VTPlayersFailedToRespond;

			[NonSerialized]
			[MarshalAs(UnmanagedType.FunctionPtr)]
			public InternalPlayersRefreshComplete m_VTPlayersRefreshComplete;
		}

		private VTable m_VTable;

		private IntPtr m_pVTable;

		private GCHandle m_pGCHandle;

		private AddPlayerToList m_AddPlayerToList;

		private PlayersFailedToRespond m_PlayersFailedToRespond;

		private PlayersRefreshComplete m_PlayersRefreshComplete;

		public ISteamMatchmakingPlayersResponse(AddPlayerToList onAddPlayerToList, PlayersFailedToRespond onPlayersFailedToRespond, PlayersRefreshComplete onPlayersRefreshComplete)
		{
		}

		~ISteamMatchmakingPlayersResponse()
		{
		}

		private void InternalOnAddPlayerToList(IntPtr thisptr, IntPtr pchName, int nScore, float flTimePlayed)
		{
		}

		private void InternalOnPlayersFailedToRespond(IntPtr thisptr)
		{
		}

		private void InternalOnPlayersRefreshComplete(IntPtr thisptr)
		{
		}

		public static explicit operator IntPtr(ISteamMatchmakingPlayersResponse that)
		{
			return (IntPtr)0;
		}
	}
}
