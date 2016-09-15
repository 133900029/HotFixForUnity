using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using CLRSharp;
public class FixUtil
{
    CLRSharp.CLRSharp_Environment env;
    CLRSharp.ThreadContext context;
    private List<string> list;
    private static FixUtil mInstance;
    public static FixUtil Instance
    {
        get
        {
            if (mInstance == null)
            {
                mInstance = new FixUtil();
            }
            return mInstance;
        }
    }

    public FixUtil()
    {
        Debug.Log("Init Start");

        list = new List<string>();
        TextAsset txt = Resources.Load("HotFix.txt") as TextAsset;
        SetConfigData(txt.text);


        env = new CLRSharp.CLRSharp_Environment(new Logger());
        TextAsset dll = Resources.Load("HotFix.dll") as TextAsset;
        TextAsset pdb = Resources.Load("HotFix.pdb") as TextAsset;
        System.IO.MemoryStream msDll = new System.IO.MemoryStream(dll.bytes);
        System.IO.MemoryStream msPdb = new System.IO.MemoryStream(pdb.bytes);
        env.LoadModule(msDll, msPdb, new Mono.Cecil.Pdb.PdbReaderProvider());
        context = new CLRSharp.ThreadContext(env);

        Debug.Log("Init End");
    }
    public bool NeedFix(string str)
    {
        bool isFix = list.Contains(str);
        Debug.Log("str  " + str + "   bool  " + isFix);
        return isFix;
    }
    public void Fix(params object[] param)
    {
        if (param == null || param.Length == 0)
            return;
        string id = param[0] as string;
        string[] nameArray = id.Split('.');
        string className = nameArray[0];
        string methodName = nameArray[1];


        CLRSharp.ICLRType wantType = env.GetType("HotFix." + className + "Hot");
        CLRSharp.IMethod method;
        MethodParamList list = null;
        if (nameArray.Length == 3)      //静态方法
        {
            list = CLRSharp.MethodParamList.Make(GetTypes(true, param));
        }
        else
        {
            list = CLRSharp.MethodParamList.Make(GetTypes(false, param));
        }

        method = wantType.GetMethod(methodName, list);
        method.Invoke(context, null, GetParams(param));
    }
    private ICLRType[] GetTypes(bool isStatic, params object[] param)//第一个参数不要，且根据是否静态加入object
    {
        if (param.Length == 1)
            return null;
        List<ICLRType> list = new List<ICLRType>();
        for (int i = 1; i < param.Length; i++)
        {
            if (!isStatic && i == 1)
            {
                list.Add(env.GetType(typeof(object)));
                continue;
            }
            list.Add(env.GetType(param[i].GetType()));
        }
        return list.ToArray();
    }
    private object[] GetParams(params object[] param)//第一个参数不要
    {
        if (param.Length == 1)
            return null;
        List<object> list = new List<object>();
        for (int i = 1; i < param.Length; i++)
        {
            list.Add((object)param[i]);
        }
        return list.ToArray();
    }

    private void SetConfigData(string txt)
    {
        string content = txt.Trim().Replace("\r\n", "\n");
        string[] strArray = content.Split('\n');
        list.Clear();
        for (int i = 0; i < strArray.Length; i++)
        {
            list.Add(strArray[i]);
        }
    }
    public class Logger : CLRSharp.ICLRSharp_Logger//实现L#的LOG接口
    {
        public void Log(string str)
        {
            Debug.Log(str);
        }

        public void Log_Error(string str)
        {
            Debug.LogError(str);
        }

        public void Log_Warning(string str)
        {
            Debug.LogWarning(str);
        }
    }
}
 
