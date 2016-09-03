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
        return;

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



}
