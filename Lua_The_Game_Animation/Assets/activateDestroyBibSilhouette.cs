using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateDestroyBibSilhouette : MonoBehaviour
{
    public GameObject TBD;
    public bool PlayerInRange;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
           
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
            
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
            TBD.SetActive(true);
        }


    }
}
