using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public new GameObject light;
    private bool on = false;
    public bool PlayerInRange;
    public GameObject ListenBox;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
            ListenBox.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
            ListenBox.SetActive(false);
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X) && PlayerInRange)
        {
            light.SetActive(true);
            on = true;
            GetComponent<Collider2D>().enabled = false;
        }


    }
}
