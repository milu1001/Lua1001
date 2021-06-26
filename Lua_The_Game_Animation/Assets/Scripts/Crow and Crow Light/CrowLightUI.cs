using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowLightUI : MonoBehaviour
{
    public bool PlayerInRange;
    public GameObject ListenBox;
    public GameObject CrowConvo1;
    public GameObject CrowConvo2;



    // Start is called before the first frame update


    // Update is called once per frame
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
            GetComponent<Collider2D>().enabled = false;
            CrowConvo1.SetActive(false);
            CrowConvo2.SetActive(true);
        }
    }
}
