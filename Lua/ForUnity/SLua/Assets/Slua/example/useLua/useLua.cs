using UnityEngine;
using System.Collections;
using SLua;
using LuaInterface;


public class useLua : MonoBehaviour {

	// Use this for initialization


    private LuaSvr luaSvr;
	void Start () {
        luaSvr = new LuaSvr();
        luaSvr.init(null, () => {
            luaSvr.start("useLua");
        }, LuaSvrFlag.LSF_DEBUG);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
