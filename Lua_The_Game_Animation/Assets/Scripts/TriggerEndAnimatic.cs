using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerEndAnimatic : MonoBehaviour
{
    public GameObject ListenBox;
    public bool PlayerInRange;
    public Animator FadeOut;
    public Animator Music;


    public void Awake()
    {
        FadeOut.speed = 0;
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
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && PlayerInRange)
        {
            Music.SetTrigger("musicFadeOut");
            FadeOut.speed = 1;

        }


    }
    public void FadeisDone()
    {
        SceneManager.LoadScene("EndAnimatic", LoadSceneMode.Single);
    }
}
