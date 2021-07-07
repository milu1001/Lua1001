using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoOverCheck2 : MonoBehaviour
{
    public VideoPlayer animatic;
    void Start()
    {

        animatic.loopPointReached += EndReached;


    }

   

    void EndReached(VideoPlayer animatic)
    {
        SceneManager.LoadScene("StartApplication", LoadSceneMode.Single);
    }


}
