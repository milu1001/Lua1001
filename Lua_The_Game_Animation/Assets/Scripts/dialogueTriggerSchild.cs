using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTriggerSchild : MonoBehaviour
{
    public GameObject DialogueBox;
    public GameObject ListenBox;
    public bool movement = true;
    private Character2DController cc;
    private Animator ani;
    public bool PlayerInRange;

    // Start is called before the first frame update
    void Start()
    {
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<Character2DController>();
        ani = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Animator>();
    }



    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
            if (!DialogueBox.activeInHierarchy)
            {
                DialogueBox.SetActive(true);
                ListenBox.SetActive(false);
                cc.enabled = false;
                ani.SetBool("isrunning", false);
            }
            else if (DialogueBox.activeInHierarchy)
            {
                cc.enabled = true;
                DialogueBox.SetActive(false);
                ListenBox.SetActive(true);
            }
        }



    }



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

}


