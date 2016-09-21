using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;



namespace HotFix
{
    public class test001Hot
    {
         
        public static void SetName(object instance ,string name)
        { 
            test001 t = instance as test001;
            t.go.name = "SetName FixSuccess";
            Debug.Log("SetName hotfix now");  
        }
        public static void SetTime(object instance)
        {
            test001 t = instance as test001;
            t.time.name = "SetTime FixSuccess";
            Debug.Log("SetTime hotfix now");
        }



        public static void SetNameStatic(object instance,string name)
        {
            Debug.Log("SetNameStatic hotfix now");
        }
        public static void SetTimeStatic(object instance)
        {
            Debug.Log("SetTimeStatic hotfix now");
        }


        public static void TestPerformance(object instance)
        {
            float timeFloat = Time.realtimeSinceStartup;
            for (int i = 0; i < 1000; i++)
            {
                GameObject go = new GameObject();
            }
            Debug.Log(Time.realtimeSinceStartup - timeFloat);
        }

    }
}
