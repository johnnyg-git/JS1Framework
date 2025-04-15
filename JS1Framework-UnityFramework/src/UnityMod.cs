using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ScheduleOne.ItemFramework;

namespace JS1Framework.UnityFramework
{
    [CreateAssetMenu(fileName = "NewMod", menuName = "JS1Framework/Mod")]
    public class UnityMod : ScriptableObject
    {
        public string modName;

        [SerializeField]
        public List<CustomItem> customItems;
    }
}