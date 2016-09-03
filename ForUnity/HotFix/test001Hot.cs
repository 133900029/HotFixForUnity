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
    }
}
