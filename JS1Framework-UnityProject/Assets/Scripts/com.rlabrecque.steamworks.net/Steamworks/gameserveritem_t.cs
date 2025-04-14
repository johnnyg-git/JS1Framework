using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 372)]
	public class gameserveritem_t
	{
		public servernetadr_t m_NetAdr;

		public int m_nPing;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bHadSuccessfulResponse;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDoNotRefresh;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szGameDir;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		private byte[] m_szMap;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szGameDescription;

		public uint m_nAppID;

		public int m_nPlayers;

		public int m_nMaxPlayers;

		public int m_nBotPlayers;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPassword;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSecure;

		public uint m_ulTimeLastPlayed;

		public int m_nServerVersion;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		private byte[] m_szServerName;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_szGameTags;

		public CSteamID m_steamID;

		public string GetGameDir()
		{
			return null;
		}

		public void SetGameDir(string dir)
		{
		}

		public string GetMap()
		{
			return null;
		}

		public void SetMap(string map)
		{
		}

		public string GetGameDescription()
		{
			return null;
		}

		public void SetGameDescription(string desc)
		{
		}

		public string GetServerName()
		{
			return null;
		}

		public void SetServerName(string name)
		{
		}

		public string GetGameTags()
		{
			return null;
		}

		public void SetGameTags(string tags)
		{
		}
	}
}
