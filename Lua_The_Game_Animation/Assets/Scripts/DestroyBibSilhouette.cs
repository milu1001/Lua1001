using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBibSilhouette : MonoBehaviour
{
    public GameObject bild;
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
            bild.SetActive(false);
            GetComponent<Collider2D>().enabled = false;
        }


    }
}