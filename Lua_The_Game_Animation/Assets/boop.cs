using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class boop : MonoBehaviour
{
    // Start is called before the first frame update
  public void boopa()
    {
        SceneManager.LoadScene("StartApplication", LoadSceneMode.Single);
    }    

}
