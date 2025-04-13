using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using MelonLoader;

using JS1Framework.Utils;

namespace JS1Framework.Core.ModHandling
{
    internal static class ModManager
    {
        internal static List<ModModule> modModules { get; private set; } = new List<ModModule>();

        private static JsonSerializerSettings jsonSettings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
        };

        internal static void Initialize()
        {
            // Get the mod directory
            // Making a local variable in case I change it at some point? idk, doesn't really matter.
            string modDirectory = PathUtils.customModsDirectory;

            // Load all mod modules from the directory
            foreach (string file in System.IO.Directory.GetFiles(modDirectory, "modmodule.json", System.IO.SearchOption.AllDirectories))
            {
                try
                {
                    string json = System.IO.File.ReadAllText(file);
                    ModModule modModule = JsonConvert.DeserializeObject<ModModule>(json, jsonSettings);
                    modModule.modDirectory = System.IO.Path.GetDirectoryName(file);
                    modModules.Add(modModule);
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"Failed to load mod module from file: {file}\n{ex}");
                }
            }

            // Load and log all mod modules
            foreach (ModModule mod in modModules)
            {
                // Load the asset bundles for the mod
                mod.LoadBundles();
                mod.RunAssetProcessors();
                MelonLogger.Msg($"Loaded Mod Module: {mod.Name} at {mod.modDirectory}");
            }
        }
    }
}