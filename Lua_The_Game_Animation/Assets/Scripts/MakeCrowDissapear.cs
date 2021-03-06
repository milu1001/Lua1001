using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeCrowDissapear : MonoBehaviour
{
    public bool PlayerInRange;
    public GameObject crow;
    public GameObject BibDoor;

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
        if (Input.GetKeyDown(KeyCode.X) && PlayerInRange)
        {
            if (crow.activeInHierarchy)
            {
                crow.SetActive(false);
                BibDoor.SetActive(false);
            }
        }


    }
}
