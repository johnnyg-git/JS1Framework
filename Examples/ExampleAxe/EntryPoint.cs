using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;
using MelonLoader;
using ScheduleOne;
using ScheduleOne.ItemFramework;

using JS1Framework.Utils;
using JS1Framework.Shops;

namespace ExampleAxe
{
    internal class EntryPoint : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading ExampleAxe...");

            AssetBundle assetBundle = AssetBundleHelper.LoadAssetBundleResource("ExampleAxe.res.customaxe");

            StorableItemDefinition axeDefinition = assetBundle.LoadAsset<StorableItemDefinition>("CustomAxe.asset");

            ArmsDealer.AddWeaponOption(WeaponType.Melee, "CustomAxe", 69, axeDefinition);

            MelonLogger.Msg("ExampleAxe loaded");
        }
    }
}