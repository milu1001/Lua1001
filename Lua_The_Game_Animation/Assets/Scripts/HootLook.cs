using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HootLook : MonoBehaviour
{
    public Transform hootDest;
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

    public void Update()
    {
        if (PlayerInRange == true)
        {
            transform.LookAt(hootDest);
        }
    }

}
