using UnityEngine;
using UnityEngine.AddressableAssets;

namespace SceneManagement
{
    [System.Serializable]
    public class SceneReference : AssetReference
    {

        public SceneReference(string guid) : base(guid)
        {
        }

        public override bool ValidateAsset(Object obj)
        {
#if UNITY_EDITOR
            var type = obj.GetType();
            return typeof(UnityEditor.SceneAsset).IsAssignableFrom(type);
#else
        return false;
#endif
        }
 
        public override bool ValidateAsset(string path)
        {
#if UNITY_EDITOR
            var type = UnityEditor.AssetDatabase.GetMainAssetTypeAtPath(path);
            return typeof(UnityEditor.SceneAsset).IsAssignableFrom(type);
#else
        return false;
#endif
        }
 
#if UNITY_EDITOR

        public new UnityEditor.SceneAsset editorAsset => (UnityEditor.SceneAsset)base.editorAsset;
#endif
    }
}
