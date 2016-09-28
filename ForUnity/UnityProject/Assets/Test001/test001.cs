using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class test001 : MonoBehaviour
{


    public GameObject go;
    public GameObject time;

    void Start()
    {

        go = new GameObject("go");
        time = new GameObject("time");

        SetName("after");
        SetTime();


        SetNameStatic("after");
        SetTimeStatic();



        //test for unity window pc at 2016.9.15 22:06//use the new L# version
        //time        10        100         1000
        //native      0.0002    0.0007      0.006
        //L#          0.026     0.26        2.69
        //all in dll  0.004     0.005       0.02
      

        //虽然all in dll的速度比L#快
        //但是使用all in dll会使所有脚本都变慢
        //而使用L# 只会让热更的脚本变慢



        //gameobject
        //         100            1000
        //native   0.0007367134   0.007022858
        //hot fix  0.006049       0.022096
        //         8.5            3.1

        //all in dll 还有很多IL代码的bug 不宜使用，而L# 无法用于大版本，当需要热更的代码太多时，无法适用
        //for i     100000
        //          0.0003578663   0.301976
        //2for i    100000 
        //          0.0006854534   0.59242


        //hotfix
        TestPerformance();
        return;



        //normal
        float timeFloat = Time.realtimeSinceStartup;
        for (int i = 0; i < 100000; i++)
        { 
        }
        for (int i = 0; i < 100000; i++)
        {
        }
        Debug.Log("Normal" + (Time.realtimeSinceStartup - timeFloat));
        return;









        //use all in dll

        if (FixUtil.Instance.NeedFix("test001.TestPerformance"))
        {
            string str = string.Format("test001,TestPerformance,{0}", typeof(object));
            FixUtil.Instance.Fix(str, this);
            return;
        }
        return;











       
        float timeFloat1 = Time.realtimeSinceStartup;



        for (int i = 0; i < 10; i++)
        {
            TestPerformance();
        }
        Debug.Log(Time.realtimeSinceStartup - timeFloat1);










    }
    public void TestPerformance()
    {
        if (FixUtil.Instance.NeedFix("test001.TestPerformance"))
        {
            string str = string.Format("test001,TestPerformance,{0}", typeof(object));
            FixUtil.Instance.Fix(str, this);
            return;
        }
        //GameObject go = new GameObject();
    }

    public void SetName(string name)
    {
        if (FixUtil.Instance.NeedFix("test001.SetName"))
        {
            string str = string.Format("test001,SetName,{0},{1}", typeof(object), typeof(string));
            FixUtil.Instance.Fix(str, this, name);
            return;
        }
        go.name = "go1";


    }
    public void SetTime()
    {
        if (FixUtil.Instance.NeedFix("test001.SetTime"))
        {
            string str = string.Format("test001,SetTime,{0}", typeof(object));
            FixUtil.Instance.Fix(str, this);
            return;
        }
        time.name = "time1";
    }


    public static void SetNameStatic(string name)
    {
        if (FixUtil.Instance.NeedFix("test001.SetNameStatic"))
        {
            string str = string.Format("test001,SetNameStatic,{0},{1}", typeof(object), typeof(string));
            FixUtil.Instance.Fix(str, null, name);
            return;
        }
        Debug.Log("SetNameStatic");
    }
    public static void SetTimeStatic()
    {
        if (FixUtil.Instance.NeedFix("test001.SetTimeStatic"))
        {
            string str = string.Format("test001,SetTimeStatic,{0}", typeof(object));
            FixUtil.Instance.Fix(str, null);
            return;
        }
        Debug.Log("SetTimeStatic");
    }

}
