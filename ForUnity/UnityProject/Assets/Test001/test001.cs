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
        //time   10        100         1000
        //native 0.0002    0.0007      0.006
        //L#     0.026     0.26        2.69
        //       130       371         448


       
        float timeFloat = Time.realtimeSinceStartup;



        for (int i = 0; i < 10; i++)
        {
            TestPerformance();
        }
        Debug.Log(Time.realtimeSinceStartup - timeFloat);

    }
    public void TestPerformance()
    {
        if (FixUtil.Instance.NeedFix("test001.TestPerformance"))
        {
            string str = string.Format("test001,TestPerformance,{0}", typeof(object));
            FixUtil.Instance.Fix(str, this);
            return;
        }
        GameObject go = new GameObject();
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
