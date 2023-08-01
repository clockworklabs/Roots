using UnityEngine;

namespace Roots
{
    public class ResourcesLoader : AssetsLoader
    {
        protected override bool LoadAsset<T>(string address, AssetLoaded<T> callback)
        {
            if (callback == null)
            {
                return false;
            }
            
            var asset = Resources.Load<T>(address);
            callback.Invoke(new Asset<T>
            {
                address = address,
                asset = asset
            });

            return true;
        }
    }
}
