using System;
using UnityEngine;
using System.Collections;

public class Water : MonoBehaviour
{
    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject duck;
    [SerializeField] private GameObject respawnR;
    [SerializeField] private GameObject respawnL;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "cat")
        {
            StartCoroutine(disableCat());
            
        }
    }

    private void respawnCat()
    {
        AudioManager.instance.playCatRespawn();
        
        if (Mathf.Abs(duck.transform.position.x - respawnR.transform.position.x) <
            Mathf.Abs(duck.transform.position.x - respawnL.transform.position.x))
        {
            cat.transform.position = respawnR.transform.position; 
        }
        else
        {
            cat.transform.position = respawnL.transform.position;
        }
        
    }

   
    IEnumerator disableCat()
    {
        
        cat.GetComponent<SpriteRenderer>().enabled = false;
        cat.GetComponent<BoxCollider2D>().enabled = false;
        cat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        yield return new WaitForSeconds(1);
        cat.GetComponent<SpriteRenderer>().enabled = true;
        cat.GetComponent<BoxCollider2D>().enabled = true;
        respawnCat();
        yield return new WaitForSeconds(1);
        cat.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        
        
        
    }
    
}
