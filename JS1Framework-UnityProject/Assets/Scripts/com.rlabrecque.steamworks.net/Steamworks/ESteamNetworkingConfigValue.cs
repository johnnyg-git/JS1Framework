namespace Steamworks
{
	public enum ESteamNetworkingConfigValue
	{
		k_ESteamNetworkingConfig_Invalid = 0,
		k_ESteamNetworkingConfig_TimeoutInitial = 24,
		k_ESteamNetworkingConfig_TimeoutConnected = 25,
		k_ESteamNetworkingConfig_SendBufferSize = 9,
		k_ESteamNetworkingConfig_RecvBufferSize = 47,
		k_ESteamNetworkingConfig_RecvBufferMessages = 48,
		k_ESteamNetworkingConfig_RecvMaxMessageSize = 49,
		k_ESteamNetworkingConfig_RecvMaxSegmentsPerPacket = 50,
		k_ESteamNetworkingConfig_ConnectionUserData = 40,
		k_ESteamNetworkingConfig_SendRateMin = 10,
		k_ESteamNetworkingConfig_SendRateMax = 11,
		k_ESteamNetworkingConfig_NagleTime = 12,
		k_ESteamNetworkingConfig_IP_AllowWithoutAuth = 23,
		k_ESteamNetworkingConfig_IPLocalHost_AllowWithoutAuth = 52,
		k_ESteamNetworkingConfig_MTU_PacketSize = 32,
		k_ESteamNetworkingConfig_MTU_DataSize = 33,
		k_ESteamNetworkingConfig_Unencrypted = 34,
		k_ESteamNetworkingConfig_SymmetricConnect = 37,
		k_ESteamNetworkingConfig_LocalVirtualPort = 38,
		k_ESteamNetworkingConfig_DualWifi_Enable = 39,
		k_ESteamNetworkingConfig_EnableDiagnosticsUI = 46,
		k_ESteamNetworkingConfig_FakePacketLoss_Send = 2,
		k_ESteamNetworkingConfig_FakePacketLoss_Recv = 3,
		k_ESteamNetworkingConfig_FakePacketLag_Send = 4,
		k_ESteamNetworkingConfig_FakePacketLag_Recv = 5,
		k_ESteamNetworkingConfig_FakePacketReorder_Send = 6,
		k_ESteamNetworkingConfig_FakePacketReorder_Recv = 7,
		k_ESteamNetworkingConfig_FakePacketReorder_Time = 8,
		k_ESteamNetworkingConfig_FakePacketDup_Send = 26,
		k_ESteamNetworkingConfig_FakePacketDup_Recv = 27,
		k_ESteamNetworkingConfig_FakePacketDup_TimeMax = 28,
		k_ESteamNetworkingConfig_PacketTraceMaxBytes = 41,
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Rate = 42,
		k_ESteamNetworkingConfig_FakeRateLimit_Send_Burst = 43,
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Rate = 44,
		k_ESteamNetworkingConfig_FakeRateLimit_Recv_Burst = 45,
		k_ESteamNetworkingConfig_OutOfOrderCorrectionWindowMicroseconds = 51,
		k_ESteamNetworkingConfig_Callback_ConnectionStatusChanged = 201,
		k_ESteamNetworkingConfig_Callback_AuthStatusChanged = 202,
		k_ESteamNetworkingConfig_Callback_RelayNetworkStatusChanged = 203,
		k_ESteamNetworkingConfig_Callback_MessagesSessionRequest = 204,
		k_ESteamNetworkingConfig_Callback_MessagesSessionFailed = 205,
		k_ESteamNetworkingConfig_Callback_CreateConnectionSignaling = 206,
		k_ESteamNetworkingConfig_Callback_FakeIPResult = 207,
		k_ESteamNetworkingConfig_P2P_STUN_ServerList = 103,
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Enable = 104,
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Penalty = 105,
		k_ESteamNetworkingConfig_P2P_Transport_SDR_Penalty = 106,
		k_ESteamNetworkingConfig_P2P_TURN_ServerList = 107,
		k_ESteamNetworkingConfig_P2P_TURN_UserList = 108,
		k_ESteamNetworkingConfig_P2P_TURN_PassList = 109,
		k_ESteamNetworkingConfig_P2P_Transport_ICE_Implementation = 110,
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFailInitial = 19,
		k_ESteamNetworkingConfig_SDRClient_ConsecutitivePingTimeoutsFail = 20,
		k_ESteamNetworkingConfig_SDRClient_MinPingsBeforePingAccurate = 21,
		k_ESteamNetworkingConfig_SDRClient_SingleSocket = 22,
		k_ESteamNetworkingConfig_SDRClient_ForceRelayCluster = 29,
		k_ESteamNetworkingConfig_SDRClient_DevTicket = 30,
		k_ESteamNetworkingConfig_SDRClient_ForceProxyAddr = 31,
		k_ESteamNetworkingConfig_SDRClient_FakeClusterPing = 36,
		k_ESteamNetworkingConfig_SDRClient_LimitPingProbesToNearestN = 60,
		k_ESteamNetworkingConfig_LogLevel_AckRTT = 13,
		k_ESteamNetworkingConfig_LogLevel_PacketDecode = 14,
		k_ESteamNetworkingConfig_LogLevel_Message = 15,
		k_ESteamNetworkingConfig_LogLevel_PacketGaps = 16,
		k_ESteamNetworkingConfig_LogLevel_P2PRendezvous = 17,
		k_ESteamNetworkingConfig_LogLevel_SDRRelayPings = 18,
		k_ESteamNetworkingConfig_ECN = 999,
		k_ESteamNetworkingConfig_DELETED_EnumerateDevVars = 35,
		k_ESteamNetworkingConfigValue__Force32Bit = int.MaxValue
	}
}
