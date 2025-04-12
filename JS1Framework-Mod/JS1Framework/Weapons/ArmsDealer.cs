using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MelonLoader;
using HarmonyLib;
using UnityEngine;
using ScheduleOne;
using ScheduleOne.ItemFramework;
using ScheduleOne.Dialogue;

namespace JS1Framework
{
    using WeaponOption = DialogueController_ArmsDealer.WeaponOption;

    public static class ArmsDealer
    {

        public enum WeaponType
        {
            Ranged,
            Melee,
            Ammo,
        }

        internal static Dictionary<WeaponType, List<WeaponOption>> WeaponOptions = new Dictionary<WeaponType, List<DialogueController_ArmsDealer.WeaponOption>>()
        {
            { WeaponType.Ranged, new List<WeaponOption>() },
            { WeaponType.Melee, new List<WeaponOption>() },
            { WeaponType.Ammo, new List<WeaponOption>() }
        };

        public static void AddWeaponOption(WeaponType type, string name, int price, StorableItemDefinition itemDefinition)
        {
            if (WeaponOptions.ContainsKey(type))
            {
                WeaponOption newWepOption = new WeaponOption()
                {
                    Name = name,
                    Item = itemDefinition,
                    Price = 69,
                    IsAvailable = true
                };

                WeaponOptions[type].Add(newWepOption);
                MelonLogger.Msg($"Added {name} to {type} weapon options.");
            }
            else
            {
                MelonLogger.Error($"Invalid weapon type: {type}");
            }
        }
    }

    [HarmonyPatch(typeof(DialogueController_ArmsDealer))]
    class ArmsDealerPatches
    {
        static List<DialogueController_ArmsDealer> patched = new List<DialogueController_ArmsDealer>();

        [HarmonyPatch("Awake")]
        [HarmonyPrefix]
        static void ArmsDealerAwakePatch(DialogueController_ArmsDealer __instance)
        {
            MelonLogger.Msg("Patching arms dealer...");

            // If this arms dealer has already been patched, skip this instance
            if (patched.Contains(__instance))
                return;

            // Add all new melee weapons to the arms dealer
            foreach (WeaponOption meleeOption in ArmsDealer.WeaponOptions[ArmsDealer.WeaponType.Melee])
            {
                MelonLogger.Msg($"Adding {meleeOption.Name} to melee weapons.");
                __instance.MeleeWeapons.Add(meleeOption);
            }

            // Add all new ranged weapons to the arms dealer
            foreach (WeaponOption rangedOption in ArmsDealer.WeaponOptions[ArmsDealer.WeaponType.Ranged])
            {
                MelonLogger.Msg($"Adding {rangedOption.Name} to ranged weapons.");
                __instance.RangedWeapons.Add(rangedOption);
            }

            // Add all new ammo to the arms dealer
            foreach (WeaponOption ammoOption in ArmsDealer.WeaponOptions[ArmsDealer.WeaponType.Ammo])
            {
                MelonLogger.Msg($"Adding {ammoOption.Name} to ammo.");
                __instance.Ammo.Add(ammoOption);
            }

            MelonLogger.Msg("Arms dealer patched successfully.");

            // Add this instance to the patched list
            patched.Add(__instance);
        }
    }
}