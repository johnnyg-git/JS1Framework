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

            harmony = new HarmonyLib.Harmony("com.johnnyjohnny.revealcounterchance");
            harmony.PatchAll();

            var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("ExampleAxe.res.customaxe");
            if (stream == null)
            {
                return;
            }

            AssetBundle assetBundle = AssetBundle.LoadFromStream(stream);
            stream.Close();

            StorableItemDefinition axeDefinition = assetBundle.LoadAsset<StorableItemDefinition>("CustomAxe.asset");

            weaponOption = new DialogueController_ArmsDealer.WeaponOption()
            {
                Name = axeDefinition.name,
                Item = axeDefinition,
                Price = 69,
                IsAvailable = true
            };

            MelonLogger.Msg("ExampleAxe loaded");
        }
    }

    [HarmonyPatch(typeof(DialogueController_ArmsDealer))]
    class ArmsDealerPatch
    {
        public static List<DialogueController_ArmsDealer> patched = new List<DialogueController_ArmsDealer>();

        [HarmonyPatch("Awake")]
        [HarmonyPrefix]
        static void ArmsDealerAwakePatch(DialogueController_ArmsDealer __instance)
        {
            if (patched.Contains(__instance))
                return;

            if (EntryPoint.weaponOption == null)
                return;

            __instance.MeleeWeapons.Add(EntryPoint.weaponOption);


            patched.Add(__instance);
        }
    }
}