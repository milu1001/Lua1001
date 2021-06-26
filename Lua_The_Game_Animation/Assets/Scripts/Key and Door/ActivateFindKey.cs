using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ActivateFindKey : MonoBehaviour
{
    public GameObject ListenBox;
    public GameObject Kommode;
    public GameObject TriggerForUpstairs;
    public bool PlayerInRange;

// Start is called before the first frame update
void Start()
{

}



public void Update()
{

    if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
    {
        if (!ListenBox.activeInHierarchy)
            {
                ListenBox.SetActive(true);
                Kommode.SetActive(true);
                TriggerForUpstairs.SetActive(true);
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