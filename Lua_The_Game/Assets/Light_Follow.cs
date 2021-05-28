using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Follow : MonoBehaviour
{

    public GameObject Lua;

    void Update()
    {
        transform.LookAt(Lua.transform);   
    }
}
