using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public new GameObject light;
    private bool on = false;

    void OnTriggerStay2D(Collider2D Lua)
    {
        if (Lua.tag == "Player" && Input.GetKeyDown(KeyCode.X) && !on)
        {
            light.SetActive(true);
            on = true; 
        }
        
    }
}
