using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoOverCheck : MonoBehaviour
{
    public VideoPlayer animatic;
    public GameObject Skip;
    void Start()
    {

        animatic.loopPointReached += EndReached;


    }

    public void SkipAni()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    void EndReached(VideoPlayer animatic)
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

   
}
