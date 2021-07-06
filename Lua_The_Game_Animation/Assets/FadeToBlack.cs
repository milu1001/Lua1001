using UnityEngine;

public class FadeToBlack : MonoBehaviour
{
    public Animator Black;
   
    void Update()
    {
        if (Input.anyKey)
        {
            FadeToLevel(1);
        }
    }

    public void FadeToLevel (int levelIndex)
    {
        Black.SetTrigger("FadeOut");
    }
}
