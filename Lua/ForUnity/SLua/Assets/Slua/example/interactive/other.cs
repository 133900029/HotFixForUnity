using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using SLua;
using LuaInterface;


[CustomLuaClass]
public class other
{
    public void Add(int a, int b)
    {
        Debug.Log(a + b);
    }

}
 
