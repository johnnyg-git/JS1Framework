using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using UnityEngine;
using MelonLoader;

namespace JS1Framework.Utils
{
    /// <summary>
    /// Provides helper methods for loading AssetBundles
    /// </summary>
    public static class AssetBundleHelper
    {
        /// <summary>
        /// Loads an AssetBundle from an embedded resource within the specified assembly.
        /// </summary>
        /// <param name="assembly">The assembly containing the embedded resource.</param>
        /// <param name="resourcePath">The path to the embedded resource.</param>
        /// <returns>
        /// The loaded AssetBundle if successful; otherwise, null.
        /// </returns>
        public static AssetBundle LoadAssetBundleResource(Assembly assembly, string resourcePath)
        {
            MelonLogger.Msg($"Loading asset bundle from resource: {resourcePath} in {assembly.FullName}");

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

            MelonLoader.MelonLogger.Msg($"Successfully loaded asset bundle: {resourcePath}");

            return assetBundle;
        }

        /// <summary>
        /// Loads an AssetBundle from an embedded resource within the calling assembly.
        /// </summary>
        /// <param name="resourcePath">The path to the embedded resource.</param>
        /// <returns>
        /// The loaded AssetBundle if successful; otherwise, null.
        /// </returns>

        public static AssetBundle LoadAssetBundleResource(string resourcePath)
        {
            return LoadAssetBundleResource(Assembly.GetCallingAssembly(), resourcePath);
        }
    }
}