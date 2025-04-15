using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using ScheduleOne.ItemFramework;

namespace JS1Framework.UnityFramework
{
    [CreateAssetMenu(fileName = "NewCustomItem", menuName = "JS1Framework/Custom Item")]
    public class CustomItem : ScriptableObject
    {
        public StorableItemDefinition itemDefinition;
        public string helloTest;
    }
}