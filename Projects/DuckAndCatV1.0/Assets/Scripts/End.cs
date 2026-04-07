using System.Collections;
using UnityEngine;

public class End : MonoBehaviour
{
    private bool duckEntered = false;
    private bool catEntered = false;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "duck")
        {
            duckEntered = true;
        }

        if (collision.gameObject.tag == "cat")
        {
            catEntered = true;
        }
    }

    void Update()
    {
        if (duckEntered && catEntered)
        {
            //play success sound
            AudioManager.instance.playSuccess();

            StartCoroutine(waitChangeScenes());
             
            //end game screen
            SceneChanger.instance.changeToEndScreen();
        }
    }
    
    IEnumerator waitChangeScenes()
    {
        yield return new WaitForSeconds(2);
    }
}
