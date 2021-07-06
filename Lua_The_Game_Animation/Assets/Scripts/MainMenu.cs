using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Play;
    public GameObject Options;
    public GameObject Exit;
    
    public void PlayGame ()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
