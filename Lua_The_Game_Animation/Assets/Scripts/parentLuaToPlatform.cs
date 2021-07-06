using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parentLuaToPlatform : MonoBehaviour
{
    public bool PlayerInRange;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
            collision.gameObject.transform.SetParent(gameObject.transform, true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
            collision.gameObject.transform.parent = null;
        }
    }
}
