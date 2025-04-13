using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MelonLoader;

using JS1Framework.Core.ModHandling;
using JS1Framework.Utils;
using System.IO;

namespace JS1Framework.Core
{
    internal class EntryPoint : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading JS1Framework...");

            PathUtils.Initialize();

            ModManager.Initialize();

            MelonLogger.Msg("JS1Framework loaded successfully.");
        }

        public override void OnDeinitializeMelon()
        {
            MelonLogger.Msg("Unloading JS1Framework...");

            // Do stuff in the future

            MelonLogger.Msg("JS1Framework unloaded successfully.");
        }
    }
}
