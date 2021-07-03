using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
  
    public AudioSource audio;

    // Start is called before the first frame update
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Step()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            audio.Play();
        }

    }

   
}
