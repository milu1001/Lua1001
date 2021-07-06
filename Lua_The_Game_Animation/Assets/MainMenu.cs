using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    void Update()
    {
        if(Input.anyKey)
        {
            SceneManager.LoadScene("ActualMenu", LoadSceneMode.Single);
        }
    }
    public void PlayGame ()
    {
        Debug.Log("funz)");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene("ActualMenu", LoadSceneMode.Single);
    }

    public void QuitGame ()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
