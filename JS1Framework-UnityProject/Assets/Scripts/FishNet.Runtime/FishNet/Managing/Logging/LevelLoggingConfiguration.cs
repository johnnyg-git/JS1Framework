using System.Runtime.CompilerServices;
using FishNet.Documenting;
using UnityEngine;

namespace FishNet.Managing.Logging
{
	[CreateAssetMenu(fileName = "New LevelLoggingConfiguration", menuName = "FishNet/Logging/Level Logging Configuration")]
	public class LevelLoggingConfiguration : LoggingConfiguration
	{
		[Tooltip("Type of logging to use for development builds and editor.")]
		[SerializeField]
		private LoggingType _developmentLogging;

		[Tooltip("Type of logging to use for GUI builds.")]
		[SerializeField]
		private LoggingType _guiLogging;

		[Tooltip("Type of logging to use for headless builds.")]
		[SerializeField]
		private LoggingType _headlessLogging;

		private bool _initialized;

		private LoggingType _highestLoggingType;

		[APIExclude]
		public void LoggingConstructor(bool loggingEnabled, LoggingType development, LoggingType gui, LoggingType headless)
		{
		}

		public override void InitializeOnce()
		{
		}

		public override bool CanLog(LoggingType loggingType)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Log(string value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void LogWarning(string value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void LogError(string value)
		{
		}

		public override LoggingConfiguration Clone()
		{
			return null;
		}
	}
}
