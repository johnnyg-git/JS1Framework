using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JS1Framework.Shops;
using MelonLoader;
using Newtonsoft.Json;
using ScheduleOne.ItemFramework;

namespace JS1Framework.Core.ModHandling.Processors
{
    [Serializable]
    public class ArmsDealerProcessor : AssetProcessor
    {
        public WeaponType weaponType;
        public string name;
        public int price;

        public override void Process(UnityEngine.Object asset)
        {
            if (asset == null)
            {
                MelonLogger.Error("The asset is null.");
                return;
            }
            if (string.IsNullOrEmpty(name))
            {
                MelonLogger.Error("The name is null or empty.");
                return;
            }
            if (price <= 0)
            {
                MelonLogger.Error("The price is less than or equal to zero.");
                return;
            }

            if (asset is StorableItemDefinition)
            {
                MelonLogger.Msg($"Adding {name} to Arms Dealer with price {price}.");
            }
            else
            {
                MelonLogger.Error($"The asset {asset.name} is not a valid StorableItemDefinition.");
                return;
            }


            ArmsDealer.AddWeaponOption(weaponType, name, price, asset as StorableItemDefinition);
        }
    }
}