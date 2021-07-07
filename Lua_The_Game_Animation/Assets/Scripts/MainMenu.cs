using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Play;
    public GameObject Options;
    public GameObject Exit;

    public Animator MenuAni;
    public Animator Music;


    public void Awake()
    {
        
    }
    public void PlayGame()
        {
            MenuAni.SetTrigger("fadeOut");
            Music.SetTrigger("musicFadeOut");
          //  SceneManager.LoadScene("Game", LoadSceneMode.Single);
        }
    
        public void QuitGame ()
        {
        Debug.Log("Quit");
        Application.Quit();
        }

    public void FadeisDone()
    {
        SceneManager.LoadScene("Animatic", LoadSceneMode.Single);
    }

}
