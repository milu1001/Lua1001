using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountLanterns : MonoBehaviour
{
    public GameObject CrowEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Lantern").Length == 14)
        {
            CrowEnd.SetActive(true);
        }
    }
}
