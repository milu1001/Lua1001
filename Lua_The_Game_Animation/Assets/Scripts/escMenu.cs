using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escMenu : MonoBehaviour
{
    public static bool IsPaused;
    public GameObject pauseMenuCanvas;


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


    public void Resume()
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

    public void ExitGame()
    {
        IsPaused = false;
        Application.Quit();

    }

}
