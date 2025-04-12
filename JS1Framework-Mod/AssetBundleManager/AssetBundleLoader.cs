using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;

namespace JS1Framework
{
    public static class AssetBundleLoader
    {
        /// <summary>
        /// Loads an AssetBundle from an embedded resource inside the specified assembly.
        /// </summary>
        public static AssetBundle LoadAssetBundleResource(Assembly assembly, string resourcePath)
        {
            // Get the stream for the embedded resource
            var stream = assembly.GetManifestResourceStream(resourcePath);
            if (stream == null)
            {
                MelonLoader.MelonLogger.Error($"Failed to load asset bundle: {resourcePath}");
                return null;
            }

            // Load the asset bundle from the stream
            AssetBundle assetBundle = AssetBundle.LoadFromStream(stream);
            stream.Close();

            if (assetBundle == null)
            {
                MelonLoader.MelonLogger.Error($"Failed to load asset bundle from stream: {resourcePath}");
                return null;
            }

            return assetBundle;
        }
    }
}