using UnityEngine;
using System.Collections;
using SLua;
using LuaInterface;

[CustomLuaClass]
public class interactive : MonoBehaviour
{

    private LuaSvr luaSvr;
    private static interactive instance;
    public static string staticStr;
    public string instanceStr;

    void Start()
    {
        instance = this;

        luaSvr = new LuaSvr();//LuaSvr创建luastate luastate创建IntPtr
        luaSvr.init(null, () =>
        {
            luaSvr.start("interactiveLua");//luastate里面跑main函数
            luaSvr.luaState.getFunction("PrintTxt").call("csPrintTxt");
            luaSvr.luaState.getFunction("NoArgs").call();
        }, LuaSvrFlag.LSF_DEBUG);//创建LuaObject
 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void StaticMethod(string txt)
    {
        Debug.Log(txt);
    }
    public void InstanceMethod(string instance)
    {
        Debug.Log(instance);
    }
    public static void GetStaticStr()
    {
        Debug.Log(staticStr);
    }
    public void GetInstanceStr()
    {
        Debug.Log(instanceStr);
    }

    public static interactive Instance()
    {
        return instance;
    }
}
