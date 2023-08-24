using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Roots
{
    public struct Asset<T> where T : Object
    {
        public string address;
        public T asset;
    }
    public delegate void AssetLoaded<T>(Asset<T> asset) where T : Object;
    
    public abstract class AssetsLoader : MonoBehaviour
    {
        private UIDocument UIDocument { get; set; }

        private static List<AssetsLoader> Loaders { get; } = new();
        
        private void Awake()
        {
            UIDocument = GetComponent<UIDocument>();
            
            Loaders.Add(this);
        }
        private void OnDestroy()
        {
            Loaders.Remove(this);
        }

        protected abstract bool LoadAsset<T>(string address, AssetLoaded<T> callback) where T : Object;
        public void Load<T>(string address, AssetLoaded<T> callback) where T : Object
        {
            if (string.IsNullOrWhiteSpace(address))
            {
                callback?.Invoke(new Asset<T>
                {
                    address = address,
                    asset = null
                });
                return;
            }
            
            if (!LoadAsset(address, callback))
            {
                callback?.Invoke(new Asset<T>
                {
                    address = address,
                    asset = null
                });
            }
        }

        public static AssetsLoader GetLoader(VisualElement visualElement)
        {
            foreach (var loader in Loaders)
            {
                if (loader.UIDocument.rootVisualElement.Contains(visualElement))
                {
                    return loader;
                }
            }

            var uiDocuments = FindObjectsByType<UIDocument>(FindObjectsSortMode.None);
            foreach (var uiDocument in uiDocuments)
            {
                if (uiDocument.rootVisualElement.Contains(visualElement))
                {
                    var loader = uiDocument.gameObject.AddComponent<ResourcesLoader>();
                    return loader;
                }
            }

            return null;
        }

        public static string GetAddressFromUSSUrl(string url) => url.StartsWith("url(") && url.EndsWith(")")
            ? url.Substring(3, url.Length - 5)
            : string.Empty;
    }
}
