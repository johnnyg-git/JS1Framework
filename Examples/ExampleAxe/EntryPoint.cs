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

/*
    Everything in this example is currently temporary for testing purposes only.
    In the future, this will be moved out of here and handled by JS1Framework.
*/
namespace ExampleAxe
{
    internal class EntryPoint : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading ExampleAxe...");

            AssetBundle assetBundle = AssetBundleLoader.LoadAssetBundleResource("ExampleAxe.res.customaxe");

            StorableItemDefinition axeDefinition = assetBundle.LoadAsset<StorableItemDefinition>("CustomAxe.asset");

            ArmsDealer.AddWeaponOption(ArmsDealer.WeaponType.Melee, "CustomAxe", 69, axeDefinition);

            MelonLogger.Msg("ExampleAxe loaded");
        }
    }
}