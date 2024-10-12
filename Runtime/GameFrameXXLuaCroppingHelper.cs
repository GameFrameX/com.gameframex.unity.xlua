using UnityEngine;
using UnityEngine.Scripting;

namespace GameFrameX.XLua.Runtime
{
    [Preserve]
    public class GameFrameXXLuaCroppingHelper : MonoBehaviour
    {
        [Preserve]
        private void Start()
        {
            _ = typeof(XLuaComponent);
#if ENABLE_TENCENT_XLUA
            _ = typeof(IXLuaManager);
            _ = typeof(XLuaManager);
#endif
        }
    }
}