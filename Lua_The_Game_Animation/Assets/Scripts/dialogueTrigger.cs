using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class dialogueTrigger : MonoBehaviour
{
    public GameObject DialogueBox;
    public GameObject ListenBox;
    public bool movement = true;
    private Character2DController cc;
    private Animator ani;
    public bool PlayerInRange;
    [TextArea(3, 10)]
    public string[] sentences;
    private int sentenceCounter;
    public TextMeshProUGUI DialogueText;
    public GameObject LastLine;

    // Start is called before the first frame update
    void Start()
    {
        cc = GameObject.FindGameObjectWithTag("Player").GetComponent<Character2DController>();
        ani = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<Animator>();
    }

 
   
    public void Update ()
    {

        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
            if (!DialogueBox.activeInHierarchy)
            {
                DialogueBox.SetActive(true);
                ListenBox.SetActive(false);
                cc.enabled = false;
                ani.SetBool("isrunning", false);
                sentenceCounter = 0;
                DialogueText.text = sentences[sentenceCounter];
            }
            else if (DialogueBox.activeInHierarchy && sentenceCounter < (sentences.Length - 1))
            {
                sentenceCounter++;
                DialogueText.text = sentences[sentenceCounter];
            }
            else if (sentenceCounter >= (sentences.Length - 1) && DialogueBox.activeInHierarchy)
            {
                DialogueBox.SetActive(false);
                ListenBox.SetActive(true);
                cc.enabled = true;
                GetComponent<Collider2D>().enabled = false;
                LastLine.SetActive(true);

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