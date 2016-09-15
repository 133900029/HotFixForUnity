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



        for (int i = 0; i < 1000; i++)
        {
            TestPerformance();
        }
        Debug.Log(Time.realtimeSinceStartup - timeFloat);

    }
    public void TestPerformance()
    {
        if (FixUtil.Instance.NeedFix("test001.TestPerformance"))
        {
            FixUtil.Instance.Fix("test001.TestPerformance", this);
            return;
        }
        GameObject go = new GameObject();
    }

    public void SetName(string name)
    {
        if (FixUtil.Instance.NeedFix("test001.SetName"))
        {
            FixUtil.Instance.Fix("test001.SetName", this, name);
            return;
        }
        go.name = "go1";


    }
    public void SetTime()
    {
        if (FixUtil.Instance.NeedFix("test001.SetTime"))
        {
            FixUtil.Instance.Fix("test001.SetTime", this);
            return;
        }
        time.name = "time1";
    }


    public static void SetNameStatic(string name)
    {
        if (FixUtil.Instance.NeedFix("test001.SetNameStatic.static"))
        {
            FixUtil.Instance.Fix("test001.SetNameStatic.static", name);
            return;
        }
        Debug.Log("SetNameStatic");
    }
    public static void SetTimeStatic()
    {
        if (FixUtil.Instance.NeedFix("test001.SetTimeStatic.static"))
        {
            FixUtil.Instance.Fix("test001.SetTimeStatic.static");
            return;
        }
        Debug.Log("SetTimeStatic");
    }

}
