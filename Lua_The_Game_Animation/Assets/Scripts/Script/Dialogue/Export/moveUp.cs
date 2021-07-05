using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public GameObject Light;
    private float movementSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
       

        if (Light.activeInHierarchy == true)
        {
            transform.position = transform.position + new Vector3 (verticalInput * movementSpeed * Time.deltaTime, 0);

        }
    }
}
