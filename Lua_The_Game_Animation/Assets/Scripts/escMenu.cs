using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class escMenu : MonoBehaviour
{
    public static bool IsPaused;
    public GameObject pauseMenuCanvas;
    public GameObject Continue;
    public GameObject Options;
    public GameObject Exit;


    void Start()
    {

        pauseMenuCanvas.SetActive(false);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!IsPaused)
            {
                Time.timeScale = 0;
                IsPaused = true;

            }
            else
            {
                Time.timeScale = 1;
                IsPaused = false;

            }
        }

        if (IsPaused)
        {
            pauseMenuCanvas.SetActive(true);

        }
        else
        {
            pauseMenuCanvas.SetActive(false);
        }
       // timeRemaining -= Time.deltaTime;

    }


    public void ContinueGame()
    {

        if (!IsPaused)
        {
            Time.timeScale = 0;
            IsPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            IsPaused = false;

        }
    }

    public void EscOptions()
    {

    }

    public void ExitToMenu()
    {
        IsPaused = false;
        print("menu");
        SceneManager.LoadScene("ActualMenu", LoadSceneMode.Single);

    }

}
