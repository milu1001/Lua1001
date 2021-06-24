using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogueWorkPls : MonoBehaviour
{
    public GameObject DialogueBox;
    public GameObject ListenBox;
    public TextMeshProUGUI DialogueText;
    public TextMeshProUGUI Listen;
    public bool PlayerInRange;
    public bool movement = true;
    private Character2DController cc;
    private Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<Character2DController>();
        ani = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {
       

        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
           if(DialogueBox.activeInHierarchy)
            {
                DialogueBox.SetActive(false);
                ListenBox.SetActive(true);
                cc.enabled = true;
            }
           else
            {
                DialogueBox.SetActive(true);
                DialogueText.text = "ok.10/10";
                ListenBox.SetActive(false);
                cc.enabled = false;
                ani.SetBool("isrunning", false);
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