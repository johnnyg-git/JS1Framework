using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsmResolver.DotNet.Bundles;
using JS1Framework.Core.ModHandling.Processors;
using MelonLoader;
using Newtonsoft.Json;
using UnityEngine;

namespace JS1Framework.Core.ModHandling
{
    [Serializable]
    public class ModModule
    {
        [Serializable]
        public class Bundle
        {
            [Serializable]
            public class Asset
            {
                [JsonIgnore]
                public UnityEngine.Object loadedAsset { get; internal set; }

                [JsonProperty]
                private string assetName;

                [JsonProperty]
                private Type assetType = null;

                [JsonProperty]
                private AssetProcessor processor = null;

                public string AssetName
                {
                    get => assetName;
                    internal set => assetName = value;
                }

                public Type AssetType
                {
                    get => assetType;
                    internal set => assetType = value;
                }

                public AssetProcessor Processor
                {
                    get => processor;
                    internal set => processor = value;
                }
            }

            [JsonIgnore]
            public AssetBundle loadedBundle { get; internal set; }

            [JsonIgnore]
            public ModModule parentModModule { get; internal set; }

            [JsonProperty]
            private string bundleDirectory;

            [JsonProperty]
            private List<Asset> assets;

            public string BundleDirectory
            {
                get => bundleDirectory;
                internal set => bundleDirectory = value;
            }

            public List<Asset> Assets
            {
                get => assets;
                internal set => assets = value;
            }

            internal void Load()
            {
                // Ensure parentModModule is set
                if (parentModModule == null)
                {
                    MelonLogger.Error("Parent ModModule is not set for the bundle.");
                    return;
                }

                LoadAssetBundle();
                LoadAssets();
            }

            private void LoadAssetBundle()
            {
                string modDirectory = parentModModule.modDirectory;

                try
                {
                    // Load the AssetBundle from the mod directory
                    string bundlePath = System.IO.Path.Combine(modDirectory, BundleDirectory);
                    loadedBundle = AssetBundle.LoadFromFile(bundlePath);
                    if (loadedBundle == null)
                    {
                        MelonLogger.Error($"Failed to load asset bundle: {bundlePath}");
                    }
                }
                catch (Exception ex)
                {
                    MelonLogger.Error($"Error loading asset bundle: {BundleDirectory} for {parentModModule.Name}\n{ex}");
                }
            }

            private void LoadAssets()
            {
                // Load all assets in the bundle
                foreach (Asset asset in assets)
                {
                    try
                    {
                        // Determine the type to use for loading the asset
                        // If the type is not set, use UnityEngine.Object as the default
                        Type typeToLoad = asset.AssetType ?? typeof(UnityEngine.Object);

                        // Load the asset from the bundle
                        asset.loadedAsset = loadedBundle.LoadAsset(asset.AssetName, typeToLoad);
                        if (asset.loadedAsset == null)
                        {
                            MelonLogger.Error($"Failed to load asset: {asset.AssetName} from bundle: {bundleDirectory}");
                            continue;
                        }

                        // Log the loaded asset
                        MelonLogger.Msg($"Successfully loaded asset: {asset.AssetName} of type {typeToLoad} from bundle: {bundleDirectory}");
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Error($"Error loading asset: {asset.AssetName} from bundle: {bundleDirectory}\n{ex}");
                    }
                }
            }
        }

        [JsonIgnore]
        public string modDirectory { get; internal set; }

        [JsonProperty]
        private string name;

        [JsonProperty]
        private List<Bundle> assetBundles;

        public string Name
        {
            get => name;
            internal set => name = value;
        }

        public List<Bundle> AssetBundles
        {
            get => assetBundles;
            internal set => assetBundles = value;
        }

        internal void LoadBundles()
        {
            // Check if the mod directory is set and exists
            if (string.IsNullOrEmpty(modDirectory) || !System.IO.Directory.Exists(modDirectory))
            {
                MelonLogger.Error($"Mod directory does not exist: {modDirectory}");
                return;
            }

            foreach (Bundle bundle in assetBundles)
            {
                // Set the parent mod module for the bundle so that it can be used inside Bundle methods
                bundle.parentModModule = this;

                // Load the bundle
                bundle.Load();
            }
        }

        internal void RunAssetProcessors()
        {
            MelonLogger.Msg($"Running asset processors for mod module: {Name}");

            // Run all asset processors in the mod module
            foreach (Bundle bundle in assetBundles)
            {
                foreach (Bundle.Asset asset in bundle.Assets)
                {
                    if (asset.loadedAsset == null)
                    {
                        MelonLogger.Error($"Asset {asset.AssetName} is not loaded.");
                        continue;
                    }

                    if (asset.Processor == null)
                    {
                        MelonLogger.Error($"No asset processor specified for asset: {asset.AssetName}");
                        continue;
                    }

                    // Process the asset using the specified processor
                    try
                    {
                        asset.Processor.Process(asset.loadedAsset);
                    }
                    catch (Exception ex)
                    {
                        MelonLogger.Error($"Error processing asset: {asset.AssetName} with processor: {asset.Processor.GetType().Name}\n{ex}");
                    }
                }
            }
        }
    }
}