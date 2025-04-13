using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JS1Framework.Core.ModHandling.Processors
{
    [Serializable]
    public abstract class AssetProcessor
    {
        public abstract void Process(UnityEngine.Object asset);
    }
}