using GameFrameX.Editor;
using GameFrameX.XLua.Runtime;
using UnityEditor;

namespace GameFrameX.XLua.Editor
{
    [CustomEditor(typeof(XLuaComponent))]
    internal sealed class XLuaComponentInspector : ComponentTypeComponentInspector
    {
        protected override void RefreshTypeNames()
        {
            RefreshComponentTypeNames(typeof(IXLuaManager));
        }

        protected override void Enable()
        {
            base.Enable();

            // m_Timeout = serializedObject.FindProperty("m_Timeout");
            serializedObject.ApplyModifiedProperties();
        }
    }
}