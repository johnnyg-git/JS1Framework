using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MelonLoader;

namespace JS1Framework.Core
{
    internal class EntryPoint : MelonMod
    {
        private const string HarmonyId = "com.johnnyjohnny.js1framework";
        private static HarmonyLib.Harmony harmony;

        static void HarmonyPatch()
        {
            MelonLogger.Msg("Starting Harmony patching...");

            harmony = new HarmonyLib.Harmony(HarmonyId);
            harmony.PatchAll();

            MelonLogger.Msg("Harmony patching complete.");
        }

        static void HarmonyUnpatch()
        {
            MelonLogger.Msg("Starting Harmony unpatching...");

            // Only unpatch if harmony has actually been initialized
            if (harmony != null)
            {
                harmony.UnpatchSelf();
                harmony = null;
            }

            MelonLogger.Msg("Harmony unpatching complete.");
        }

        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading JS1Framework...");

            HarmonyPatch();

            MelonLogger.Msg("JS1Framework loaded successfully.");
        }

        public override void OnDeinitializeMelon()
        {
            MelonLogger.Msg("Unloading JS1Framework...");

            HarmonyUnpatch();

            MelonLogger.Msg("JS1Framework unloaded successfully.");
        }
    }
}
