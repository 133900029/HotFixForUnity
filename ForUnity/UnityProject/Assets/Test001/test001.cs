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
