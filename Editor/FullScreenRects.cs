using UnityEditor;
using UnityEngine;

namespace yugop.fullscreen
{
    /// <summary>Returns main display rect for fullscreen.</summary>
    public static class FullScreenRects
    {
        /// <summary>Main display rect in editor points (DPI-corrected so ContainerWindow scale matches).</summary>
        public static Rect GetMainDisplayRect()
        {
#if UNITY_EDITOR_WIN
            if (Application.platform == RuntimePlatform.WindowsEditor)
                return Windows.MainDisplayRect.GetUnityCorrectedRect();
#endif
            var w = Screen.currentResolution.width;
            var h = Screen.currentResolution.height;
            var rect = new Rect(0f, 0f, w, h);

            if (Application.platform == RuntimePlatform.OSXEditor)
                return EditorGUIUtility.PixelsToPoints(rect);

            return rect;
        }
    }
}
