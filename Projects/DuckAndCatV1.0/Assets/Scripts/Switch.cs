using UnityEditor;
using UnityEngine;

public class Switch : MonoBehaviour
{
    //getting the switch components
    [SerializeField] private GameObject onLight;
    [SerializeField] private GameObject offLight;
    [SerializeField] private GameObject lever;
    [SerializeField] private Rigidbody2D leverRB;

    //lever drag
    [SerializeField] private float drag;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //when lever reaches x position of the lights, it should stop moving that direction
        if (lever.transform.position.x <= onLight.transform.position.x)
        {
            leverRB.linearVelocity = new Vector3(leverRB.linearVelocity.x * drag, leverRB.linearVelocity.y,0);
        }

        if (lever.transform.position.x >= offLight.transform.position.x)
        {
            leverRB.linearVelocity = new Vector3(leverRB.linearVelocity.x * drag, leverRB.linearVelocity.y,0);
        }
    }
}
