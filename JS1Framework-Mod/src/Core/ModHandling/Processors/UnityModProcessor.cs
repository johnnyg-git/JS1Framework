using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JS1Framework.Shops;
using MelonLoader;
using Newtonsoft.Json;
using ScheduleOne.ItemFramework;
using JS1Framework.UnityFramework;
using UnityEngine;

namespace JS1Framework.Core.ModHandling.Processors
{
    [Serializable]
    public class UnityModProcessor : AssetProcessor
    {
        public override void Process(UnityEngine.Object asset)
        {
            if (asset == null)
            {
                MelonLogger.Error("The asset is null.");
                return;
            }

            if (asset is UnityMod unityMod)
            {
                MelonLogger.Msg($"Processing UnityMod: {unityMod.modName}");
            }
            else
            {
                MelonLogger.Error($"The asset {asset.name} is not a valid UnityMod.");
                return;
            }

            // TODO
        }
    }
}