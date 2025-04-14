namespace Steamworks
{
	public static class Constants
	{
		public const string STEAMAPPS_INTERFACE_VERSION = "STEAMAPPS_INTERFACE_VERSION008";

		public const string STEAMAPPTICKET_INTERFACE_VERSION = "STEAMAPPTICKET_INTERFACE_VERSION001";

		public const string STEAMCLIENT_INTERFACE_VERSION = "SteamClient021";

		public const string STEAMFRIENDS_INTERFACE_VERSION = "SteamFriends017";

		public const string STEAMGAMECOORDINATOR_INTERFACE_VERSION = "SteamGameCoordinator001";

		public const string STEAMGAMESERVER_INTERFACE_VERSION = "SteamGameServer015";

		public const string STEAMGAMESERVERSTATS_INTERFACE_VERSION = "SteamGameServerStats001";

		public const string STEAMHTMLSURFACE_INTERFACE_VERSION = "STEAMHTMLSURFACE_INTERFACE_VERSION_005";

		public const string STEAMHTTP_INTERFACE_VERSION = "STEAMHTTP_INTERFACE_VERSION003";

		public const string STEAMINPUT_INTERFACE_VERSION = "SteamInput006";

		public const string STEAMINVENTORY_INTERFACE_VERSION = "STEAMINVENTORY_INTERFACE_V003";

		public const string STEAMMATCHMAKING_INTERFACE_VERSION = "SteamMatchMaking009";

		public const string STEAMMATCHMAKINGSERVERS_INTERFACE_VERSION = "SteamMatchMakingServers002";

		public const string STEAMGAMESEARCH_INTERFACE_VERSION = "SteamMatchGameSearch001";

		public const string STEAMPARTIES_INTERFACE_VERSION = "SteamParties002";

		public const string STEAMMUSIC_INTERFACE_VERSION = "STEAMMUSIC_INTERFACE_VERSION001";

		public const string STEAMMUSICREMOTE_INTERFACE_VERSION = "STEAMMUSICREMOTE_INTERFACE_VERSION001";

		public const string STEAMNETWORKING_INTERFACE_VERSION = "SteamNetworking006";

		public const string STEAMNETWORKINGMESSAGES_INTERFACE_VERSION = "SteamNetworkingMessages002";

		public const string STEAMNETWORKINGSOCKETS_INTERFACE_VERSION = "SteamNetworkingSockets012";

		public const string STEAMNETWORKINGUTILS_INTERFACE_VERSION = "SteamNetworkingUtils004";

		public const string STEAMPARENTALSETTINGS_INTERFACE_VERSION = "STEAMPARENTALSETTINGS_INTERFACE_VERSION001";

		public const string STEAMREMOTEPLAY_INTERFACE_VERSION = "STEAMREMOTEPLAY_INTERFACE_VERSION002";

		public const string STEAMREMOTESTORAGE_INTERFACE_VERSION = "STEAMREMOTESTORAGE_INTERFACE_VERSION016";

		public const string STEAMSCREENSHOTS_INTERFACE_VERSION = "STEAMSCREENSHOTS_INTERFACE_VERSION003";

		public const string STEAMTIMELINE_INTERFACE_VERSION = "STEAMTIMELINE_INTERFACE_V001";

		public const string STEAMUGC_INTERFACE_VERSION = "STEAMUGC_INTERFACE_VERSION020";

		public const string STEAMUSER_INTERFACE_VERSION = "SteamUser023";

		public const string STEAMUSERSTATS_INTERFACE_VERSION = "STEAMUSERSTATS_INTERFACE_VERSION012";

		public const string STEAMUTILS_INTERFACE_VERSION = "SteamUtils010";

		public const string STEAMVIDEO_INTERFACE_VERSION = "STEAMVIDEO_INTERFACE_V007";

		public const int k_cubAppProofOfPurchaseKeyMax = 240;

		public const int k_cchMaxFriendsGroupName = 64;

		public const int k_cFriendsGroupLimit = 100;

		public const int k_cEnumerateFollowersMax = 50;

		public const ushort k_usFriendGameInfoQueryPort_NotInitialized = ushort.MaxValue;

		public const ushort k_usFriendGameInfoQueryPort_Error = 65534;

		public const int k_cchPersonaNameMax = 128;

		public const int k_cwchPersonaNameMax = 32;

		public const int k_cubChatMetadataMax = 8192;

		public const int k_cchMaxRichPresenceKeys = 30;

		public const int k_cchMaxRichPresenceKeyLength = 64;

		public const int k_cchMaxRichPresenceValueLength = 256;

		public const int k_unFavoriteFlagNone = 0;

		public const int k_unFavoriteFlagFavorite = 1;

		public const int k_unFavoriteFlagHistory = 2;

		public const int k_unMaxCloudFileChunkSize = 104857600;

		public const int k_cchPublishedDocumentTitleMax = 129;

		public const int k_cchPublishedDocumentDescriptionMax = 8000;

		public const int k_cchPublishedDocumentChangeDescriptionMax = 8000;

		public const int k_unEnumeratePublishedFilesMaxResults = 50;

		public const int k_cchTagListMax = 1025;

		public const int k_cchFilenameMax = 260;

		public const int k_cchPublishedFileURLMax = 256;

		public const int k_nScreenshotMaxTaggedUsers = 32;

		public const int k_nScreenshotMaxTaggedPublishedFiles = 32;

		public const int k_cubUFSTagTypeMax = 255;

		public const int k_cubUFSTagValueMax = 255;

		public const int k_ScreenshotThumbWidth = 200;

		public const int k_unMaxTimelinePriority = 1000;

		public const float k_flMaxTimelineEventDuration = 600f;

		public const int kNumUGCResultsPerPage = 50;

		public const int k_cchDeveloperMetadataMax = 5000;

		public const int k_nCubTicketMaxLength = 2560;

		public const int k_cchStatNameMax = 128;

		public const int k_cchLeaderboardNameMax = 128;

		public const int k_cLeaderboardDetailsMax = 64;

		public const int k_cbMaxGameServerGameDir = 32;

		public const int k_cbMaxGameServerMapName = 32;

		public const int k_cbMaxGameServerGameDescription = 64;

		public const int k_cbMaxGameServerName = 64;

		public const int k_cbMaxGameServerTags = 128;

		public const int k_cbMaxGameServerGameData = 2048;

		public const int k_cchMaxSteamErrMsg = 1024;

		public const int k_iSteamUserCallbacks = 100;

		public const int k_iSteamGameServerCallbacks = 200;

		public const int k_iSteamFriendsCallbacks = 300;

		public const int k_iSteamBillingCallbacks = 400;

		public const int k_iSteamMatchmakingCallbacks = 500;

		public const int k_iSteamContentServerCallbacks = 600;

		public const int k_iSteamUtilsCallbacks = 700;

		public const int k_iSteamAppsCallbacks = 1000;

		public const int k_iSteamUserStatsCallbacks = 1100;

		public const int k_iSteamNetworkingCallbacks = 1200;

		public const int k_iSteamNetworkingSocketsCallbacks = 1220;

		public const int k_iSteamNetworkingMessagesCallbacks = 1250;

		public const int k_iSteamNetworkingUtilsCallbacks = 1280;

		public const int k_iSteamRemoteStorageCallbacks = 1300;

		public const int k_iSteamGameServerItemsCallbacks = 1500;

		public const int k_iSteamGameCoordinatorCallbacks = 1700;

		public const int k_iSteamGameServerStatsCallbacks = 1800;

		public const int k_iSteam2AsyncCallbacks = 1900;

		public const int k_iSteamGameStatsCallbacks = 2000;

		public const int k_iSteamHTTPCallbacks = 2100;

		public const int k_iSteamScreenshotsCallbacks = 2300;

		public const int k_iSteamStreamLauncherCallbacks = 2600;

		public const int k_iSteamControllerCallbacks = 2800;

		public const int k_iSteamUGCCallbacks = 3400;

		public const int k_iSteamStreamClientCallbacks = 3500;

		public const int k_iSteamMusicCallbacks = 4000;

		public const int k_iSteamMusicRemoteCallbacks = 4100;

		public const int k_iSteamGameNotificationCallbacks = 4400;

		public const int k_iSteamHTMLSurfaceCallbacks = 4500;

		public const int k_iSteamVideoCallbacks = 4600;

		public const int k_iSteamInventoryCallbacks = 4700;

		public const int k_ISteamParentalSettingsCallbacks = 5000;

		public const int k_iSteamGameSearchCallbacks = 5200;

		public const int k_iSteamPartiesCallbacks = 5300;

		public const int k_iSteamSTARCallbacks = 5500;

		public const int k_iSteamRemotePlayCallbacks = 5700;

		public const int k_iSteamChatCallbacks = 5900;

		public const int k_iSteamTimelineCallbacks = 6000;

		public const ushort STEAMGAMESERVER_QUERY_PORT_SHARED = ushort.MaxValue;

		public const int k_unSteamAccountIDMask = -1;

		public const int k_unSteamAccountInstanceMask = 1048575;

		public const int k_unSteamUserDefaultInstance = 1;

		public const int k_cchGameExtraInfoMax = 64;

		public const int k_nSteamEncryptedAppTicketSymmetricKeyLen = 32;

		public const int k_nMaxReturnPorts = 8;

		public const int k_cchMaxSteamNetworkingErrMsg = 1024;

		public const int k_cchSteamNetworkingMaxConnectionCloseReason = 128;

		public const int k_cchSteamNetworkingMaxConnectionDescription = 128;

		public const int k_cchSteamNetworkingMaxConnectionAppName = 32;

		public const int k_nSteamNetworkConnectionInfoFlags_Unauthenticated = 1;

		public const int k_nSteamNetworkConnectionInfoFlags_Unencrypted = 2;

		public const int k_nSteamNetworkConnectionInfoFlags_LoopbackBuffers = 4;

		public const int k_nSteamNetworkConnectionInfoFlags_Fast = 8;

		public const int k_nSteamNetworkConnectionInfoFlags_Relayed = 16;

		public const int k_nSteamNetworkConnectionInfoFlags_DualWifi = 32;

		public const int k_cbMaxSteamNetworkingSocketsMessageSizeSend = 524288;

		public const int k_nSteamNetworkingSend_Unreliable = 0;

		public const int k_nSteamNetworkingSend_NoNagle = 1;

		public const int k_nSteamNetworkingSend_UnreliableNoNagle = 1;

		public const int k_nSteamNetworkingSend_NoDelay = 4;

		public const int k_nSteamNetworkingSend_UnreliableNoDelay = 5;

		public const int k_nSteamNetworkingSend_Reliable = 8;

		public const int k_nSteamNetworkingSend_ReliableNoNagle = 9;

		public const int k_nSteamNetworkingSend_UseCurrentThread = 16;

		public const int k_nSteamNetworkingSend_AutoRestartBrokenSession = 32;

		public const int k_cchMaxSteamNetworkingPingLocationString = 1024;

		public const int k_nSteamNetworkingPing_Failed = -1;

		public const int k_nSteamNetworkingPing_Unknown = -2;

		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Default = -1;

		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Disable = 0;

		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Relay = 1;

		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Private = 2;

		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_Public = 4;

		public const int k_nSteamNetworkingConfig_P2P_Transport_ICE_Enable_All = int.MaxValue;

		public const ulong k_ulPartyBeaconIdInvalid = 0uL;

		public const int INVALID_HTTPREQUEST_HANDLE = 0;

		public const int STEAM_INPUT_MAX_COUNT = 16;

		public const int STEAM_INPUT_MAX_ANALOG_ACTIONS = 24;

		public const int STEAM_INPUT_MAX_DIGITAL_ACTIONS = 256;

		public const int STEAM_INPUT_MAX_ORIGINS = 8;

		public const int STEAM_INPUT_MAX_ACTIVE_LAYERS = 16;

		public const ulong STEAM_INPUT_HANDLE_ALL_CONTROLLERS = ulong.MaxValue;

		public const float STEAM_INPUT_MIN_ANALOG_ACTION_DATA = -1f;

		public const float STEAM_INPUT_MAX_ANALOG_ACTION_DATA = 1f;

		public const byte k_nMaxLobbyKeyLength = byte.MaxValue;

		public const int k_SteamMusicNameMaxLength = 255;

		public const int k_SteamMusicPNGMaxLength = 65535;
	}
}
