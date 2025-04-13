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

namespace JS1Framework.Shops
{
    using WeaponOption = DialogueController_ArmsDealer.WeaponOption;

    public static class ArmsDealer
    {

        internal static Dictionary<WeaponType, List<WeaponOption>> WeaponOptions = new Dictionary<WeaponType, List<WeaponOption>>()
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
        static HashSet<DialogueController_ArmsDealer> patched = new HashSet<DialogueController_ArmsDealer>();

        [HarmonyPatch("Awake")]
        [HarmonyPrefix]
        static void ArmsDealerAwakePatch(DialogueController_ArmsDealer __instance)
        {
            MelonLogger.Msg("Patching arms dealer...");

            // If this arms dealer has already been patched, skip this instance
            if (!patched.Add(__instance))
                return;

            // Loop through the weapon options and add them to the appropriate lists
            foreach (KeyValuePair<WeaponType, List<WeaponOption>> weaponTypeListPair in ArmsDealer.WeaponOptions)
            {
                foreach (WeaponOption weaponOption in weaponTypeListPair.Value)
                {
                    MelonLogger.Msg($"Adding {weaponOption.Name} to {weaponTypeListPair.Key} weapons.");
                    switch (weaponTypeListPair.Key)
                    {
                        case WeaponType.Melee:
                            __instance.MeleeWeapons.Add(weaponOption);
                            break;
                        case WeaponType.Ranged:
                            __instance.RangedWeapons.Add(weaponOption);
                            break;
                        case WeaponType.Ammo:
                            __instance.Ammo.Add(weaponOption);
                            break;
                    }
                }
            }

            MelonLogger.Msg("Arms dealer patched successfully.");
        }
    }
}