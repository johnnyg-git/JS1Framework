namespace Steamworks
{
	public enum EInputActionOrigin
	{
		k_EInputActionOrigin_None = 0,
		k_EInputActionOrigin_SteamController_A = 1,
		k_EInputActionOrigin_SteamController_B = 2,
		k_EInputActionOrigin_SteamController_X = 3,
		k_EInputActionOrigin_SteamController_Y = 4,
		k_EInputActionOrigin_SteamController_LeftBumper = 5,
		k_EInputActionOrigin_SteamController_RightBumper = 6,
		k_EInputActionOrigin_SteamController_LeftGrip = 7,
		k_EInputActionOrigin_SteamController_RightGrip = 8,
		k_EInputActionOrigin_SteamController_Start = 9,
		k_EInputActionOrigin_SteamController_Back = 10,
		k_EInputActionOrigin_SteamController_LeftPad_Touch = 11,
		k_EInputActionOrigin_SteamController_LeftPad_Swipe = 12,
		k_EInputActionOrigin_SteamController_LeftPad_Click = 13,
		k_EInputActionOrigin_SteamController_LeftPad_DPadNorth = 14,
		k_EInputActionOrigin_SteamController_LeftPad_DPadSouth = 15,
		k_EInputActionOrigin_SteamController_LeftPad_DPadWest = 16,
		k_EInputActionOrigin_SteamController_LeftPad_DPadEast = 17,
		k_EInputActionOrigin_SteamController_RightPad_Touch = 18,
		k_EInputActionOrigin_SteamController_RightPad_Swipe = 19,
		k_EInputActionOrigin_SteamController_RightPad_Click = 20,
		k_EInputActionOrigin_SteamController_RightPad_DPadNorth = 21,
		k_EInputActionOrigin_SteamController_RightPad_DPadSouth = 22,
		k_EInputActionOrigin_SteamController_RightPad_DPadWest = 23,
		k_EInputActionOrigin_SteamController_RightPad_DPadEast = 24,
		k_EInputActionOrigin_SteamController_LeftTrigger_Pull = 25,
		k_EInputActionOrigin_SteamController_LeftTrigger_Click = 26,
		k_EInputActionOrigin_SteamController_RightTrigger_Pull = 27,
		k_EInputActionOrigin_SteamController_RightTrigger_Click = 28,
		k_EInputActionOrigin_SteamController_LeftStick_Move = 29,
		k_EInputActionOrigin_SteamController_LeftStick_Click = 30,
		k_EInputActionOrigin_SteamController_LeftStick_DPadNorth = 31,
		k_EInputActionOrigin_SteamController_LeftStick_DPadSouth = 32,
		k_EInputActionOrigin_SteamController_LeftStick_DPadWest = 33,
		k_EInputActionOrigin_SteamController_LeftStick_DPadEast = 34,
		k_EInputActionOrigin_SteamController_Gyro_Move = 35,
		k_EInputActionOrigin_SteamController_Gyro_Pitch = 36,
		k_EInputActionOrigin_SteamController_Gyro_Yaw = 37,
		k_EInputActionOrigin_SteamController_Gyro_Roll = 38,
		k_EInputActionOrigin_SteamController_Reserved0 = 39,
		k_EInputActionOrigin_SteamController_Reserved1 = 40,
		k_EInputActionOrigin_SteamController_Reserved2 = 41,
		k_EInputActionOrigin_SteamController_Reserved3 = 42,
		k_EInputActionOrigin_SteamController_Reserved4 = 43,
		k_EInputActionOrigin_SteamController_Reserved5 = 44,
		k_EInputActionOrigin_SteamController_Reserved6 = 45,
		k_EInputActionOrigin_SteamController_Reserved7 = 46,
		k_EInputActionOrigin_SteamController_Reserved8 = 47,
		k_EInputActionOrigin_SteamController_Reserved9 = 48,
		k_EInputActionOrigin_SteamController_Reserved10 = 49,
		k_EInputActionOrigin_PS4_X = 50,
		k_EInputActionOrigin_PS4_Circle = 51,
		k_EInputActionOrigin_PS4_Triangle = 52,
		k_EInputActionOrigin_PS4_Square = 53,
		k_EInputActionOrigin_PS4_LeftBumper = 54,
		k_EInputActionOrigin_PS4_RightBumper = 55,
		k_EInputActionOrigin_PS4_Options = 56,
		k_EInputActionOrigin_PS4_Share = 57,
		k_EInputActionOrigin_PS4_LeftPad_Touch = 58,
		k_EInputActionOrigin_PS4_LeftPad_Swipe = 59,
		k_EInputActionOrigin_PS4_LeftPad_Click = 60,
		k_EInputActionOrigin_PS4_LeftPad_DPadNorth = 61,
		k_EInputActionOrigin_PS4_LeftPad_DPadSouth = 62,
		k_EInputActionOrigin_PS4_LeftPad_DPadWest = 63,
		k_EInputActionOrigin_PS4_LeftPad_DPadEast = 64,
		k_EInputActionOrigin_PS4_RightPad_Touch = 65,
		k_EInputActionOrigin_PS4_RightPad_Swipe = 66,
		k_EInputActionOrigin_PS4_RightPad_Click = 67,
		k_EInputActionOrigin_PS4_RightPad_DPadNorth = 68,
		k_EInputActionOrigin_PS4_RightPad_DPadSouth = 69,
		k_EInputActionOrigin_PS4_RightPad_DPadWest = 70,
		k_EInputActionOrigin_PS4_RightPad_DPadEast = 71,
		k_EInputActionOrigin_PS4_CenterPad_Touch = 72,
		k_EInputActionOrigin_PS4_CenterPad_Swipe = 73,
		k_EInputActionOrigin_PS4_CenterPad_Click = 74,
		k_EInputActionOrigin_PS4_CenterPad_DPadNorth = 75,
		k_EInputActionOrigin_PS4_CenterPad_DPadSouth = 76,
		k_EInputActionOrigin_PS4_CenterPad_DPadWest = 77,
		k_EInputActionOrigin_PS4_CenterPad_DPadEast = 78,
		k_EInputActionOrigin_PS4_LeftTrigger_Pull = 79,
		k_EInputActionOrigin_PS4_LeftTrigger_Click = 80,
		k_EInputActionOrigin_PS4_RightTrigger_Pull = 81,
		k_EInputActionOrigin_PS4_RightTrigger_Click = 82,
		k_EInputActionOrigin_PS4_LeftStick_Move = 83,
		k_EInputActionOrigin_PS4_LeftStick_Click = 84,
		k_EInputActionOrigin_PS4_LeftStick_DPadNorth = 85,
		k_EInputActionOrigin_PS4_LeftStick_DPadSouth = 86,
		k_EInputActionOrigin_PS4_LeftStick_DPadWest = 87,
		k_EInputActionOrigin_PS4_LeftStick_DPadEast = 88,
		k_EInputActionOrigin_PS4_RightStick_Move = 89,
		k_EInputActionOrigin_PS4_RightStick_Click = 90,
		k_EInputActionOrigin_PS4_RightStick_DPadNorth = 91,
		k_EInputActionOrigin_PS4_RightStick_DPadSouth = 92,
		k_EInputActionOrigin_PS4_RightStick_DPadWest = 93,
		k_EInputActionOrigin_PS4_RightStick_DPadEast = 94,
		k_EInputActionOrigin_PS4_DPad_North = 95,
		k_EInputActionOrigin_PS4_DPad_South = 96,
		k_EInputActionOrigin_PS4_DPad_West = 97,
		k_EInputActionOrigin_PS4_DPad_East = 98,
		k_EInputActionOrigin_PS4_Gyro_Move = 99,
		k_EInputActionOrigin_PS4_Gyro_Pitch = 100,
		k_EInputActionOrigin_PS4_Gyro_Yaw = 101,
		k_EInputActionOrigin_PS4_Gyro_Roll = 102,
		k_EInputActionOrigin_PS4_DPad_Move = 103,
		k_EInputActionOrigin_PS4_Reserved1 = 104,
		k_EInputActionOrigin_PS4_Reserved2 = 105,
		k_EInputActionOrigin_PS4_Reserved3 = 106,
		k_EInputActionOrigin_PS4_Reserved4 = 107,
		k_EInputActionOrigin_PS4_Reserved5 = 108,
		k_EInputActionOrigin_PS4_Reserved6 = 109,
		k_EInputActionOrigin_PS4_Reserved7 = 110,
		k_EInputActionOrigin_PS4_Reserved8 = 111,
		k_EInputActionOrigin_PS4_Reserved9 = 112,
		k_EInputActionOrigin_PS4_Reserved10 = 113,
		k_EInputActionOrigin_XBoxOne_A = 114,
		k_EInputActionOrigin_XBoxOne_B = 115,
		k_EInputActionOrigin_XBoxOne_X = 116,
		k_EInputActionOrigin_XBoxOne_Y = 117,
		k_EInputActionOrigin_XBoxOne_LeftBumper = 118,
		k_EInputActionOrigin_XBoxOne_RightBumper = 119,
		k_EInputActionOrigin_XBoxOne_Menu = 120,
		k_EInputActionOrigin_XBoxOne_View = 121,
		k_EInputActionOrigin_XBoxOne_LeftTrigger_Pull = 122,
		k_EInputActionOrigin_XBoxOne_LeftTrigger_Click = 123,
		k_EInputActionOrigin_XBoxOne_RightTrigger_Pull = 124,
		k_EInputActionOrigin_XBoxOne_RightTrigger_Click = 125,
		k_EInputActionOrigin_XBoxOne_LeftStick_Move = 126,
		k_EInputActionOrigin_XBoxOne_LeftStick_Click = 127,
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadNorth = 128,
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadSouth = 129,
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadWest = 130,
		k_EInputActionOrigin_XBoxOne_LeftStick_DPadEast = 131,
		k_EInputActionOrigin_XBoxOne_RightStick_Move = 132,
		k_EInputActionOrigin_XBoxOne_RightStick_Click = 133,
		k_EInputActionOrigin_XBoxOne_RightStick_DPadNorth = 134,
		k_EInputActionOrigin_XBoxOne_RightStick_DPadSouth = 135,
		k_EInputActionOrigin_XBoxOne_RightStick_DPadWest = 136,
		k_EInputActionOrigin_XBoxOne_RightStick_DPadEast = 137,
		k_EInputActionOrigin_XBoxOne_DPad_North = 138,
		k_EInputActionOrigin_XBoxOne_DPad_South = 139,
		k_EInputActionOrigin_XBoxOne_DPad_West = 140,
		k_EInputActionOrigin_XBoxOne_DPad_East = 141,
		k_EInputActionOrigin_XBoxOne_DPad_Move = 142,
		k_EInputActionOrigin_XBoxOne_LeftGrip_Lower = 143,
		k_EInputActionOrigin_XBoxOne_LeftGrip_Upper = 144,
		k_EInputActionOrigin_XBoxOne_RightGrip_Lower = 145,
		k_EInputActionOrigin_XBoxOne_RightGrip_Upper = 146,
		k_EInputActionOrigin_XBoxOne_Share = 147,
		k_EInputActionOrigin_XBoxOne_Reserved6 = 148,
		k_EInputActionOrigin_XBoxOne_Reserved7 = 149,
		k_EInputActionOrigin_XBoxOne_Reserved8 = 150,
		k_EInputActionOrigin_XBoxOne_Reserved9 = 151,
		k_EInputActionOrigin_XBoxOne_Reserved10 = 152,
		k_EInputActionOrigin_XBox360_A = 153,
		k_EInputActionOrigin_XBox360_B = 154,
		k_EInputActionOrigin_XBox360_X = 155,
		k_EInputActionOrigin_XBox360_Y = 156,
		k_EInputActionOrigin_XBox360_LeftBumper = 157,
		k_EInputActionOrigin_XBox360_RightBumper = 158,
		k_EInputActionOrigin_XBox360_Start = 159,
		k_EInputActionOrigin_XBox360_Back = 160,
		k_EInputActionOrigin_XBox360_LeftTrigger_Pull = 161,
		k_EInputActionOrigin_XBox360_LeftTrigger_Click = 162,
		k_EInputActionOrigin_XBox360_RightTrigger_Pull = 163,
		k_EInputActionOrigin_XBox360_RightTrigger_Click = 164,
		k_EInputActionOrigin_XBox360_LeftStick_Move = 165,
		k_EInputActionOrigin_XBox360_LeftStick_Click = 166,
		k_EInputActionOrigin_XBox360_LeftStick_DPadNorth = 167,
		k_EInputActionOrigin_XBox360_LeftStick_DPadSouth = 168,
		k_EInputActionOrigin_XBox360_LeftStick_DPadWest = 169,
		k_EInputActionOrigin_XBox360_LeftStick_DPadEast = 170,
		k_EInputActionOrigin_XBox360_RightStick_Move = 171,
		k_EInputActionOrigin_XBox360_RightStick_Click = 172,
		k_EInputActionOrigin_XBox360_RightStick_DPadNorth = 173,
		k_EInputActionOrigin_XBox360_RightStick_DPadSouth = 174,
		k_EInputActionOrigin_XBox360_RightStick_DPadWest = 175,
		k_EInputActionOrigin_XBox360_RightStick_DPadEast = 176,
		k_EInputActionOrigin_XBox360_DPad_North = 177,
		k_EInputActionOrigin_XBox360_DPad_South = 178,
		k_EInputActionOrigin_XBox360_DPad_West = 179,
		k_EInputActionOrigin_XBox360_DPad_East = 180,
		k_EInputActionOrigin_XBox360_DPad_Move = 181,
		k_EInputActionOrigin_XBox360_Reserved1 = 182,
		k_EInputActionOrigin_XBox360_Reserved2 = 183,
		k_EInputActionOrigin_XBox360_Reserved3 = 184,
		k_EInputActionOrigin_XBox360_Reserved4 = 185,
		k_EInputActionOrigin_XBox360_Reserved5 = 186,
		k_EInputActionOrigin_XBox360_Reserved6 = 187,
		k_EInputActionOrigin_XBox360_Reserved7 = 188,
		k_EInputActionOrigin_XBox360_Reserved8 = 189,
		k_EInputActionOrigin_XBox360_Reserved9 = 190,
		k_EInputActionOrigin_XBox360_Reserved10 = 191,
		k_EInputActionOrigin_Switch_A = 192,
		k_EInputActionOrigin_Switch_B = 193,
		k_EInputActionOrigin_Switch_X = 194,
		k_EInputActionOrigin_Switch_Y = 195,
		k_EInputActionOrigin_Switch_LeftBumper = 196,
		k_EInputActionOrigin_Switch_RightBumper = 197,
		k_EInputActionOrigin_Switch_Plus = 198,
		k_EInputActionOrigin_Switch_Minus = 199,
		k_EInputActionOrigin_Switch_Capture = 200,
		k_EInputActionOrigin_Switch_LeftTrigger_Pull = 201,
		k_EInputActionOrigin_Switch_LeftTrigger_Click = 202,
		k_EInputActionOrigin_Switch_RightTrigger_Pull = 203,
		k_EInputActionOrigin_Switch_RightTrigger_Click = 204,
		k_EInputActionOrigin_Switch_LeftStick_Move = 205,
		k_EInputActionOrigin_Switch_LeftStick_Click = 206,
		k_EInputActionOrigin_Switch_LeftStick_DPadNorth = 207,
		k_EInputActionOrigin_Switch_LeftStick_DPadSouth = 208,
		k_EInputActionOrigin_Switch_LeftStick_DPadWest = 209,
		k_EInputActionOrigin_Switch_LeftStick_DPadEast = 210,
		k_EInputActionOrigin_Switch_RightStick_Move = 211,
		k_EInputActionOrigin_Switch_RightStick_Click = 212,
		k_EInputActionOrigin_Switch_RightStick_DPadNorth = 213,
		k_EInputActionOrigin_Switch_RightStick_DPadSouth = 214,
		k_EInputActionOrigin_Switch_RightStick_DPadWest = 215,
		k_EInputActionOrigin_Switch_RightStick_DPadEast = 216,
		k_EInputActionOrigin_Switch_DPad_North = 217,
		k_EInputActionOrigin_Switch_DPad_South = 218,
		k_EInputActionOrigin_Switch_DPad_West = 219,
		k_EInputActionOrigin_Switch_DPad_East = 220,
		k_EInputActionOrigin_Switch_ProGyro_Move = 221,
		k_EInputActionOrigin_Switch_ProGyro_Pitch = 222,
		k_EInputActionOrigin_Switch_ProGyro_Yaw = 223,
		k_EInputActionOrigin_Switch_ProGyro_Roll = 224,
		k_EInputActionOrigin_Switch_DPad_Move = 225,
		k_EInputActionOrigin_Switch_Reserved1 = 226,
		k_EInputActionOrigin_Switch_Reserved2 = 227,
		k_EInputActionOrigin_Switch_Reserved3 = 228,
		k_EInputActionOrigin_Switch_Reserved4 = 229,
		k_EInputActionOrigin_Switch_Reserved5 = 230,
		k_EInputActionOrigin_Switch_Reserved6 = 231,
		k_EInputActionOrigin_Switch_Reserved7 = 232,
		k_EInputActionOrigin_Switch_Reserved8 = 233,
		k_EInputActionOrigin_Switch_Reserved9 = 234,
		k_EInputActionOrigin_Switch_Reserved10 = 235,
		k_EInputActionOrigin_Switch_RightGyro_Move = 236,
		k_EInputActionOrigin_Switch_RightGyro_Pitch = 237,
		k_EInputActionOrigin_Switch_RightGyro_Yaw = 238,
		k_EInputActionOrigin_Switch_RightGyro_Roll = 239,
		k_EInputActionOrigin_Switch_LeftGyro_Move = 240,
		k_EInputActionOrigin_Switch_LeftGyro_Pitch = 241,
		k_EInputActionOrigin_Switch_LeftGyro_Yaw = 242,
		k_EInputActionOrigin_Switch_LeftGyro_Roll = 243,
		k_EInputActionOrigin_Switch_LeftGrip_Lower = 244,
		k_EInputActionOrigin_Switch_LeftGrip_Upper = 245,
		k_EInputActionOrigin_Switch_RightGrip_Lower = 246,
		k_EInputActionOrigin_Switch_RightGrip_Upper = 247,
		k_EInputActionOrigin_Switch_JoyConButton_N = 248,
		k_EInputActionOrigin_Switch_JoyConButton_E = 249,
		k_EInputActionOrigin_Switch_JoyConButton_S = 250,
		k_EInputActionOrigin_Switch_JoyConButton_W = 251,
		k_EInputActionOrigin_Switch_Reserved15 = 252,
		k_EInputActionOrigin_Switch_Reserved16 = 253,
		k_EInputActionOrigin_Switch_Reserved17 = 254,
		k_EInputActionOrigin_Switch_Reserved18 = 255,
		k_EInputActionOrigin_Switch_Reserved19 = 256,
		k_EInputActionOrigin_Switch_Reserved20 = 257,
		k_EInputActionOrigin_PS5_X = 258,
		k_EInputActionOrigin_PS5_Circle = 259,
		k_EInputActionOrigin_PS5_Triangle = 260,
		k_EInputActionOrigin_PS5_Square = 261,
		k_EInputActionOrigin_PS5_LeftBumper = 262,
		k_EInputActionOrigin_PS5_RightBumper = 263,
		k_EInputActionOrigin_PS5_Option = 264,
		k_EInputActionOrigin_PS5_Create = 265,
		k_EInputActionOrigin_PS5_Mute = 266,
		k_EInputActionOrigin_PS5_LeftPad_Touch = 267,
		k_EInputActionOrigin_PS5_LeftPad_Swipe = 268,
		k_EInputActionOrigin_PS5_LeftPad_Click = 269,
		k_EInputActionOrigin_PS5_LeftPad_DPadNorth = 270,
		k_EInputActionOrigin_PS5_LeftPad_DPadSouth = 271,
		k_EInputActionOrigin_PS5_LeftPad_DPadWest = 272,
		k_EInputActionOrigin_PS5_LeftPad_DPadEast = 273,
		k_EInputActionOrigin_PS5_RightPad_Touch = 274,
		k_EInputActionOrigin_PS5_RightPad_Swipe = 275,
		k_EInputActionOrigin_PS5_RightPad_Click = 276,
		k_EInputActionOrigin_PS5_RightPad_DPadNorth = 277,
		k_EInputActionOrigin_PS5_RightPad_DPadSouth = 278,
		k_EInputActionOrigin_PS5_RightPad_DPadWest = 279,
		k_EInputActionOrigin_PS5_RightPad_DPadEast = 280,
		k_EInputActionOrigin_PS5_CenterPad_Touch = 281,
		k_EInputActionOrigin_PS5_CenterPad_Swipe = 282,
		k_EInputActionOrigin_PS5_CenterPad_Click = 283,
		k_EInputActionOrigin_PS5_CenterPad_DPadNorth = 284,
		k_EInputActionOrigin_PS5_CenterPad_DPadSouth = 285,
		k_EInputActionOrigin_PS5_CenterPad_DPadWest = 286,
		k_EInputActionOrigin_PS5_CenterPad_DPadEast = 287,
		k_EInputActionOrigin_PS5_LeftTrigger_Pull = 288,
		k_EInputActionOrigin_PS5_LeftTrigger_Click = 289,
		k_EInputActionOrigin_PS5_RightTrigger_Pull = 290,
		k_EInputActionOrigin_PS5_RightTrigger_Click = 291,
		k_EInputActionOrigin_PS5_LeftStick_Move = 292,
		k_EInputActionOrigin_PS5_LeftStick_Click = 293,
		k_EInputActionOrigin_PS5_LeftStick_DPadNorth = 294,
		k_EInputActionOrigin_PS5_LeftStick_DPadSouth = 295,
		k_EInputActionOrigin_PS5_LeftStick_DPadWest = 296,
		k_EInputActionOrigin_PS5_LeftStick_DPadEast = 297,
		k_EInputActionOrigin_PS5_RightStick_Move = 298,
		k_EInputActionOrigin_PS5_RightStick_Click = 299,
		k_EInputActionOrigin_PS5_RightStick_DPadNorth = 300,
		k_EInputActionOrigin_PS5_RightStick_DPadSouth = 301,
		k_EInputActionOrigin_PS5_RightStick_DPadWest = 302,
		k_EInputActionOrigin_PS5_RightStick_DPadEast = 303,
		k_EInputActionOrigin_PS5_DPad_North = 304,
		k_EInputActionOrigin_PS5_DPad_South = 305,
		k_EInputActionOrigin_PS5_DPad_West = 306,
		k_EInputActionOrigin_PS5_DPad_East = 307,
		k_EInputActionOrigin_PS5_Gyro_Move = 308,
		k_EInputActionOrigin_PS5_Gyro_Pitch = 309,
		k_EInputActionOrigin_PS5_Gyro_Yaw = 310,
		k_EInputActionOrigin_PS5_Gyro_Roll = 311,
		k_EInputActionOrigin_PS5_DPad_Move = 312,
		k_EInputActionOrigin_PS5_LeftGrip = 313,
		k_EInputActionOrigin_PS5_RightGrip = 314,
		k_EInputActionOrigin_PS5_LeftFn = 315,
		k_EInputActionOrigin_PS5_RightFn = 316,
		k_EInputActionOrigin_PS5_Reserved5 = 317,
		k_EInputActionOrigin_PS5_Reserved6 = 318,
		k_EInputActionOrigin_PS5_Reserved7 = 319,
		k_EInputActionOrigin_PS5_Reserved8 = 320,
		k_EInputActionOrigin_PS5_Reserved9 = 321,
		k_EInputActionOrigin_PS5_Reserved10 = 322,
		k_EInputActionOrigin_PS5_Reserved11 = 323,
		k_EInputActionOrigin_PS5_Reserved12 = 324,
		k_EInputActionOrigin_PS5_Reserved13 = 325,
		k_EInputActionOrigin_PS5_Reserved14 = 326,
		k_EInputActionOrigin_PS5_Reserved15 = 327,
		k_EInputActionOrigin_PS5_Reserved16 = 328,
		k_EInputActionOrigin_PS5_Reserved17 = 329,
		k_EInputActionOrigin_PS5_Reserved18 = 330,
		k_EInputActionOrigin_PS5_Reserved19 = 331,
		k_EInputActionOrigin_PS5_Reserved20 = 332,
		k_EInputActionOrigin_SteamDeck_A = 333,
		k_EInputActionOrigin_SteamDeck_B = 334,
		k_EInputActionOrigin_SteamDeck_X = 335,
		k_EInputActionOrigin_SteamDeck_Y = 336,
		k_EInputActionOrigin_SteamDeck_L1 = 337,
		k_EInputActionOrigin_SteamDeck_R1 = 338,
		k_EInputActionOrigin_SteamDeck_Menu = 339,
		k_EInputActionOrigin_SteamDeck_View = 340,
		k_EInputActionOrigin_SteamDeck_LeftPad_Touch = 341,
		k_EInputActionOrigin_SteamDeck_LeftPad_Swipe = 342,
		k_EInputActionOrigin_SteamDeck_LeftPad_Click = 343,
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadNorth = 344,
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadSouth = 345,
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadWest = 346,
		k_EInputActionOrigin_SteamDeck_LeftPad_DPadEast = 347,
		k_EInputActionOrigin_SteamDeck_RightPad_Touch = 348,
		k_EInputActionOrigin_SteamDeck_RightPad_Swipe = 349,
		k_EInputActionOrigin_SteamDeck_RightPad_Click = 350,
		k_EInputActionOrigin_SteamDeck_RightPad_DPadNorth = 351,
		k_EInputActionOrigin_SteamDeck_RightPad_DPadSouth = 352,
		k_EInputActionOrigin_SteamDeck_RightPad_DPadWest = 353,
		k_EInputActionOrigin_SteamDeck_RightPad_DPadEast = 354,
		k_EInputActionOrigin_SteamDeck_L2_SoftPull = 355,
		k_EInputActionOrigin_SteamDeck_L2 = 356,
		k_EInputActionOrigin_SteamDeck_R2_SoftPull = 357,
		k_EInputActionOrigin_SteamDeck_R2 = 358,
		k_EInputActionOrigin_SteamDeck_LeftStick_Move = 359,
		k_EInputActionOrigin_SteamDeck_L3 = 360,
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadNorth = 361,
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadSouth = 362,
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadWest = 363,
		k_EInputActionOrigin_SteamDeck_LeftStick_DPadEast = 364,
		k_EInputActionOrigin_SteamDeck_LeftStick_Touch = 365,
		k_EInputActionOrigin_SteamDeck_RightStick_Move = 366,
		k_EInputActionOrigin_SteamDeck_R3 = 367,
		k_EInputActionOrigin_SteamDeck_RightStick_DPadNorth = 368,
		k_EInputActionOrigin_SteamDeck_RightStick_DPadSouth = 369,
		k_EInputActionOrigin_SteamDeck_RightStick_DPadWest = 370,
		k_EInputActionOrigin_SteamDeck_RightStick_DPadEast = 371,
		k_EInputActionOrigin_SteamDeck_RightStick_Touch = 372,
		k_EInputActionOrigin_SteamDeck_L4 = 373,
		k_EInputActionOrigin_SteamDeck_R4 = 374,
		k_EInputActionOrigin_SteamDeck_L5 = 375,
		k_EInputActionOrigin_SteamDeck_R5 = 376,
		k_EInputActionOrigin_SteamDeck_DPad_Move = 377,
		k_EInputActionOrigin_SteamDeck_DPad_North = 378,
		k_EInputActionOrigin_SteamDeck_DPad_South = 379,
		k_EInputActionOrigin_SteamDeck_DPad_West = 380,
		k_EInputActionOrigin_SteamDeck_DPad_East = 381,
		k_EInputActionOrigin_SteamDeck_Gyro_Move = 382,
		k_EInputActionOrigin_SteamDeck_Gyro_Pitch = 383,
		k_EInputActionOrigin_SteamDeck_Gyro_Yaw = 384,
		k_EInputActionOrigin_SteamDeck_Gyro_Roll = 385,
		k_EInputActionOrigin_SteamDeck_Reserved1 = 386,
		k_EInputActionOrigin_SteamDeck_Reserved2 = 387,
		k_EInputActionOrigin_SteamDeck_Reserved3 = 388,
		k_EInputActionOrigin_SteamDeck_Reserved4 = 389,
		k_EInputActionOrigin_SteamDeck_Reserved5 = 390,
		k_EInputActionOrigin_SteamDeck_Reserved6 = 391,
		k_EInputActionOrigin_SteamDeck_Reserved7 = 392,
		k_EInputActionOrigin_SteamDeck_Reserved8 = 393,
		k_EInputActionOrigin_SteamDeck_Reserved9 = 394,
		k_EInputActionOrigin_SteamDeck_Reserved10 = 395,
		k_EInputActionOrigin_SteamDeck_Reserved11 = 396,
		k_EInputActionOrigin_SteamDeck_Reserved12 = 397,
		k_EInputActionOrigin_SteamDeck_Reserved13 = 398,
		k_EInputActionOrigin_SteamDeck_Reserved14 = 399,
		k_EInputActionOrigin_SteamDeck_Reserved15 = 400,
		k_EInputActionOrigin_SteamDeck_Reserved16 = 401,
		k_EInputActionOrigin_SteamDeck_Reserved17 = 402,
		k_EInputActionOrigin_SteamDeck_Reserved18 = 403,
		k_EInputActionOrigin_SteamDeck_Reserved19 = 404,
		k_EInputActionOrigin_SteamDeck_Reserved20 = 405,
		k_EInputActionOrigin_Count = 406,
		k_EInputActionOrigin_MaximumPossibleValue = 32767
	}
}
