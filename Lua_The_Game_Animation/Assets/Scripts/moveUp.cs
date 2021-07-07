using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public GameObject Light;
    public float movementSpeed = 3f;
    public float noLower;
    public float noHigher;
    public bool PlayerInRange;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");

        if (transform.localPosition.y >= noLower && transform.localPosition.y <= noHigher)
        {
            if (Light.activeInHierarchy == true && PlayerInRange)
            {
                transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime);
            }
        }

        if (transform.localPosition.y <= noLower)
        {
            transform.position = transform.position + new Vector3(0,noLower + 0.01f);
        }

        if (transform.localPosition.y >= noHigher)
        {
            transform.localPosition =  new Vector3(0, noHigher - 0.02f);
        }



    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerInRange = false;
        }
    }
}
