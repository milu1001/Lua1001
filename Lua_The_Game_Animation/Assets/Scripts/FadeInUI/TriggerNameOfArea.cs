using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerNameOfArea : MonoBehaviour
{
    public GameObject EnterUI;
    public float timeToAppear = 6f;
    private float timeWhenDisappear;
    public Animator TheHotel ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EnterUI.SetActive(true);
            timeWhenDisappear = Time.time + timeToAppear;
        }
    }
    void Update()
    {
        if (EnterUI.activeInHierarchy && (Time.time >= timeWhenDisappear))
        {
            EnterUI.SetActive(false);
            GetComponent<Collider2D>().enabled = false;

        }
    }
}
