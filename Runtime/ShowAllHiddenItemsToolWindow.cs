#if UNITY_EDITOR
using PufferSoftware.Utilities;
using UnityEditor;
using UnityEngine;

namespace PufferSoftware.Editor
{
    public class ShowAllHiddenItemsToolWindow : MonoBehaviour
    {
        [MenuItem("Puffer Software/Show All Hidden Items", false, 1)]
        public static void ShowAllHiddenItems()
        {
            foreach (GameObject obj in FindObjectsOfType<GameObject>())
            {
                if (obj.hideFlags == HideFlags.HideInHierarchy)
                {
                    obj.hideFlags = HideFlags.None;
                }
            }

            EditorApplication.RepaintHierarchyWindow();
            PSDebug.Log("<color=orange> <color=green>Success : </color>All Hidden Items Showing!</color>");
        }
    }
}

#endif