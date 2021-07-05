using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationEvents : MonoBehaviour
{
    private climb cl;
    private Character2DController cc;
    private GameObject Lua;
    public float moveUp;
    public float moveToSide;

    private void Awake()
    {
        cl = GameObject.FindGameObjectWithTag("Player").GetComponent<climb>();
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<Character2DController>();
        Lua = GameObject.FindGameObjectWithTag("Player");
        
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
    }
    public void MoveUpwards()
    {
        //Lua.transform.position = Smoothdamp()
    }
    public void MoveSidewards()
    {
        if (cl.isFacingRight)
        {
            Debug.Log("MoveR");
        }
        else 
        {
            Debug.Log("MoveL");
        }
    }

}
