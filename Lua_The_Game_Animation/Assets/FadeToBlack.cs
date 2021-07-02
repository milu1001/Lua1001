using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToBlack : MonoBehaviour
{
    public Animator Black;
    // Start is called before the first frame update
    void Start()
    {
        Black.speed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Black.speed = 1;
        }
    }
}
