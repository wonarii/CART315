using UnityEngine;

public class Lever : MonoBehaviour
{
    
    [SerializeField] private GameObject greenLight;
    
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
            lightOn();
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        
        if (collider.gameObject.CompareTag("onLight"))
        {
            lightOff();
        }
    }

    private void lightOn()
    {
        greenLight.GetComponent<SpriteRenderer>().color = new Color32(77, 205, 108, 255);
        Debug.Log("On");
    }

    private void lightOff()
    {
        greenLight.GetComponent<SpriteRenderer>().color = new Color32(65, 47, 73, 255);
        Debug.Log("Off");
    }
}
