using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;
using MelonLoader;

namespace JS1Framework.Utils
{
    public static class PathUtils
    {
        public static string gameDirectory { get; private set; }
        public static string customModsDirectory { get; private set; }

        internal static void Initialize()
        {
            // Get the game directory and custom mods directory
            gameDirectory = Application.dataPath;
            customModsDirectory = System.IO.Path.Combine(gameDirectory, "../JS1FrameworkMods");

            // Check if the custom mods directory exists, if not, create it
            if (!System.IO.Directory.Exists(customModsDirectory))
            {
                System.IO.Directory.CreateDirectory(customModsDirectory);
                MelonLogger.Msg($"Created Custom Mods Directory: {customModsDirectory}");
            }

            // Log the directories
            MelonLogger.Msg($"Game Directory: {gameDirectory}");
            MelonLogger.Msg($"Custom Mods Directory: {customModsDirectory}");
        }
    }
}