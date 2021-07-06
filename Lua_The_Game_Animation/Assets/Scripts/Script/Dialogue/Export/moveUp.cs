using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveUp : MonoBehaviour
{
    public GameObject Light;
    private float movementSpeed = 1f;
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
        print(transform.position.y);

        if (transform.localPosition.y >= noLower && transform.localPosition.y <= noHigher)
        {
            if (Light.activeInHierarchy == true && PlayerInRange)
            {
                transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime);
            }
        }
         
        //if (transform.localPosition.y >= noLower )
        //{
        //    if (Light.activeInHierarchy == true && PlayerInRange && velocity.y >= 0)
        //    {
        //        transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime);
        //    }
        //}

        //if (transform.localPosition.y >= noLower && transform.localPosition.y <= noHigher)
        //{
        //    if (Light.activeInHierarchy == true && PlayerInRange)
        //    {
        //        transform.position = transform.position + new Vector3(0, verticalInput * movementSpeed * Time.deltaTime);
        //    }
        //}

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
