using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateDoorUpstairs : MonoBehaviour
{
    public bool PlayerInRange;
    public GameObject Door;
    public GameObject HootConvo1;
    public GameObject HootConvo2;
    public GameObject HootConvo3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
            if (!Door.activeInHierarchy)
            {
                Door.SetActive(true);
                HootConvo3.SetActive(false);
                HootConvo1.SetActive(false);
                HootConvo2.SetActive(true);


            }
            else if (Door.activeInHierarchy)
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
