using System;
using UnityEngine;

public class Lever : MonoBehaviour
{
    
    [SerializeField] private GameObject greenLight;
    [SerializeField] private GameObject redLight;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("onLight"))
        {
            greenLightOn();
            //door sound
            AudioManager.instance.playDoor();
        }
        if (collider.gameObject.CompareTag("offLight"))
        {
            redLightOn();
            //door sound
            AudioManager.instance.playDoor();
        }
    }

    private void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("onLight"))
        {
            Door1.Door1Instance.openDoor();
        }
        if (collider.gameObject.CompareTag("offLight"))
        {
            Door1.Door1Instance.closeDoor();
        }
        
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("onLight"))
        {
            greenLightOff();
        }
        if (collider.gameObject.CompareTag("offLight"))
        {
            redLightOff();
        }
    }

    private void greenLightOn()
    {
        greenLight.GetComponent<SpriteRenderer>().color = new Color32(77, 205, 108, 255);
        Debug.Log("On");
    }

    private void greenLightOff()
    {
        greenLight.GetComponent<SpriteRenderer>().color = new Color32(65, 47, 73, 255);
        Debug.Log("Off");
    }
    
    private void redLightOn()
    {
        redLight.GetComponent<SpriteRenderer>().color = new Color32(205, 77, 77, 255);
        Debug.Log("On");
    }

    private void redLightOff()
    {
        redLight.GetComponent<SpriteRenderer>().color = new Color32(65, 47, 73, 255);
        Debug.Log("Off");
    }
    
    
}
