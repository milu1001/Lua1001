using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationEvents : MonoBehaviour
{
    private climb cl;
    private Character2DController cc;
    private GameObject Lua;
    Transform child;

    private void Awake()
    {
        cl = GameObject.FindGameObjectWithTag("Player").GetComponent<climb>();
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<Character2DController>();
        Lua = GameObject.FindGameObjectWithTag("Player");
        child = Lua.transform.Find("Idle/mixamorig:Hips");
        
    }
    public void lockMovement()
    {
        cl.enabled = false;
        cc.enabled = false;
    }

    public void unlockMovement()
    {
        cl.enabled = true;
        cc.enabled = true;
        //Lua.transform.position = child.position;
      
    }

}
