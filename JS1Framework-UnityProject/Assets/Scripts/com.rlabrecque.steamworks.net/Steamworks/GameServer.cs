namespace Steamworks
{
	public static class GameServer
	{
		public static ESteamAPIInitResult InitEx(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString, out string OutSteamErrMsg)
		{
			OutSteamErrMsg = null;
			return default(ESteamAPIInitResult);
		}

		public static bool Init(uint unIP, ushort usGamePort, ushort usQueryPort, EServerMode eServerMode, string pchVersionString)
		{
			return false;
		}

		public static void Shutdown()
		{
		}

		public static void RunCallbacks()
		{
		}

		public static void ReleaseCurrentThreadMemory()
		{
		}

		public static bool BSecure()
		{
			return false;
		}

		public static CSteamID GetSteamID()
		{
			return default(CSteamID);
		}

		public static HSteamPipe GetHSteamPipe()
		{
			return default(HSteamPipe);
		}

		public static HSteamUser GetHSteamUser()
		{
			return default(HSteamUser);
		}
	}
}
