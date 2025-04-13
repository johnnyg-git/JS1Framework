using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;
using MelonLoader;
using ScheduleOne;
using JS1Framework;
using ScheduleOne.ItemFramework;

namespace ExamplePistol
{
    internal class EntryPoint : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading ExamplePistol...");

            AssetBundle assetBundle = AssetBundleLoader.LoadAssetBundleResource("ExamplePistol.res.custompistol");

            StorableItemDefinition pistolDefinition = assetBundle.LoadAsset<StorableItemDefinition>("CustomPistol.asset");
            StorableItemDefinition ammoDefinitionz = assetBundle.LoadAsset<StorableItemDefinition>("CustomPistolAmmo.asset");

            ArmsDealer.AddWeaponOption(ArmsDealer.WeaponType.Ranged, "Custom Pistol", 690, pistolDefinition);
            ArmsDealer.AddWeaponOption(ArmsDealer.WeaponType.Ammo, "Custom Ammo", 690, ammoDefinitionz);

            MelonLogger.Msg("ExamplePistol loaded");
        }
    }
}