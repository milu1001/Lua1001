using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLightUI : MonoBehaviour
{
    public GameObject LightUI;
    public bool PlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
            if (!LightUI.activeInHierarchy)
            {
                LightUI.SetActive(true);
            }
                
            else if (LightUI.activeInHierarchy)
            {
                GetComponent<Collider2D>().enabled = false;
            }
        }
    }
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
}
