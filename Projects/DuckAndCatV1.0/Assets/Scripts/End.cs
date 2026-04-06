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
            //end game screen
        }
    }
}
