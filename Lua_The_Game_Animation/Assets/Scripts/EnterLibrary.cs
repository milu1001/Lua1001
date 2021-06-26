using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterLibrary : MonoBehaviour
{
    public GameObject Sphere1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Sphere1.activeInHierarchy)
        {
            GetComponent<Collider2D>().enabled = false;
        }
    }
}
