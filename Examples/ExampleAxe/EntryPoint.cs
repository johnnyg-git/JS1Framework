using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;
using HarmonyLib;
using MelonLoader;
using ScheduleOne;
using JS1Framework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Dialogue;

/*
    Everything in this example is currently temporary for testing purposes only.
    In the future, this will be moved out of here and handled by JS1Framework.
*/
namespace ExampleAxe
{
    internal class EntryPoint : MelonMod
    {
        internal static DialogueController_ArmsDealer.WeaponOption weaponOption;

        static HarmonyLib.Harmony harmony;


        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Loading ExampleAxe...");

            harmony = new HarmonyLib.Harmony("com.johnnyjohnny.exampleaxe");
            harmony.PatchAll();

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ExampleAxe.res.customaxe");
            if (stream == null)
            {
                return;
            }

            AssetBundle assetBundle = AssetBundle.LoadFromStream(stream);
            stream.Close();

            StorableItemDefinition axeDefinition = assetBundle.LoadAsset<StorableItemDefinition>("CustomAxe.asset");

            ArmsDealer.AddWeaponOption(ArmsDealer.WeaponType.Melee, "CustomAxe", 69, axeDefinition);

            MelonLogger.Msg("ExampleAxe loaded");
        }
    }
}