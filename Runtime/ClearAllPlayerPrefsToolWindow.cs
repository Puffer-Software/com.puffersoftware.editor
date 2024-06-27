#if UNITY_EDITOR
using PufferSoftware.Utilities;
using UnityEditor;
using UnityEngine;

namespace PufferSoftware.Editor
{
    public class ClearAllPlayerPrefsToolWindow : MonoBehaviour
    {
        [MenuItem("Aurora/Clear All Player Prefs", false, 1)]
        public static void ClearAllPlayerPrefs()
        {
            PlayerPrefs.DeleteAll();
            PSDebug.Log("<color=orange> <color=green>Success : </color>All Player Prefs Cleared!</color>");
        }
    }
}

#endif
