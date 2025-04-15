using UnityEditor;
using UnityEngine;
using System.IO;

namespace JS1Framework.UnityFramework
{
    [CustomEditor(typeof(UnityMod))]
    public class UnityModEditor : Editor
    {
        private const string ModModuleTemplate = @"{
    ""name"": ""{MOD_NAME}"",
    ""assetBundles"": [
        {
            ""bundleDirectory"": ""{BUNDLE_NAME}"",
            ""assets"": [
                {
                    ""assetName"": ""{ASSET_NAME}.asset"",
                    ""assetType"": ""JS1Framework.UnityFramework.UnityMod, JS1Framework-UnityFramework"",
                    ""processor"": {
                        ""$type"": ""JS1Framework.Core.ModHandling.Processors.UnityModProcessor, JS1Framework""
                    }
                }
            ]
        }
    ]
}";

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Build Mod"))
            {
                BuildMod(target as UnityMod);
            }
        }

        private void BuildMod(UnityMod mod)
        {
            if (string.IsNullOrEmpty(mod.modName))
            {
                Debug.LogError("Mod name is not set!");
                return;
            }

            // Create mod folder
            string modFolder = Path.Combine(Application.dataPath, "BuiltMods", mod.modName);

            if (Directory.Exists(modFolder))
            {
                Directory.Delete(modFolder, true);
            }
            Directory.CreateDirectory(modFolder);

            // Create temporary build directory
            string tempBuildPath = Path.Combine(Path.GetTempPath(), "TempAssetBundles_" + System.Guid.NewGuid().ToString());
            Directory.CreateDirectory(tempBuildPath);

            try
            {
                // Get asset info
                string assetPath = AssetDatabase.GetAssetPath(mod);
                AssetImporter importer = AssetImporter.GetAtPath(assetPath);

                if (string.IsNullOrEmpty(importer.assetBundleName))
                {
                    Debug.LogError("Asset bundle not assigned to UnityMod asset!");
                    return;
                }

                string bundleName = importer.assetBundleName;
                string assetFileName = Path.GetFileName(assetPath);
                string assetName = Path.GetFileNameWithoutExtension(assetFileName);

                // Build asset bundle to temp directory
                AssetBundleBuild[] buildMap = new AssetBundleBuild[1];
                buildMap[0].assetBundleName = bundleName;
                buildMap[0].assetNames = AssetDatabase.GetAssetPathsFromAssetBundle(bundleName);

                AssetBundleManifest manifest = BuildPipeline.BuildAssetBundles(
                    tempBuildPath,
                    buildMap,
                    BuildAssetBundleOptions.ChunkBasedCompression,
                    BuildTarget.StandaloneWindows
                );

                if (manifest == null)
                {
                    Debug.LogError("Asset bundle build failed!");
                    return;
                }

                // Copy the specific asset bundle to mod folder
                string bundleSourcePath = Path.Combine(tempBuildPath, bundleName);
                string bundleDestPath = Path.Combine(modFolder, bundleName);

                if (File.Exists(bundleSourcePath))
                {
                    File.Copy(bundleSourcePath, bundleDestPath, true);
                }
                else
                {
                    Debug.LogError($"Built asset bundle not found at: {bundleSourcePath}");
                    return;
                }

                // Create modmodule.json
                string jsonContent = ModModuleTemplate
                    .Replace("{MOD_NAME}", mod.modName)
                    .Replace("{BUNDLE_NAME}", bundleName)
                    .Replace("{ASSET_NAME}", assetName);

                string jsonPath = Path.Combine(modFolder, "modmodule.json");
                File.WriteAllText(jsonPath, jsonContent);

                // Refresh asset database
                AssetDatabase.Refresh();
                Debug.Log($"Mod built successfully at: {modFolder}");
            }
            finally
            {
                // Clean up temp directory
                if (Directory.Exists(tempBuildPath))
                {
                    try
                    {
                        Directory.Delete(tempBuildPath, true);
                    }
                    catch (System.Exception e)
                    {
                        Debug.LogWarning($"Failed to clean up temp directory: {e.Message}");
                    }
                }
            }
        }

    }
}