using System;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    //move zones
    [SerializeField] GameObject moveZoneR;
    [SerializeField] GameObject moveZoneL;
    
    //camera itself
    [SerializeField] Camera camera;
    [SerializeField] private float cameraSpeed;
    
    //players
    [SerializeField] Rigidbody2D duck;
    [SerializeField] Rigidbody2D cat;
    
    //camera velocity idk
    public  Vector3 velocity = new Vector3(0,0,2);
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
       
        //when cat is past the move line, move camera so cat is about 1/4 way on the screen
        //BUT if duck is too close to the other edge (move zone) no camera movement allowed!!!!
        
        //checking the right
        //if cat is close to right edge and duck is not close to left edge
        if (cat.transform.position.x > moveZoneR.transform.position.x && duck.transform.position.x > moveZoneL.transform.position.x)
        {
           
            moveCamera(1);
        }
        
        //checking left
        //if cat is close to left edge and duck is not close to right edge
        if (cat.transform.position.x < moveZoneL.transform.position.x && duck.transform.position.x < moveZoneR.transform.position.x)
        {
           
            moveCamera(-1);
        }
    }

    private void moveCamera(int direction)
    {
        Vector3 targetPos= new Vector3(camera.transform.position.x + cameraSpeed * direction, camera.transform.position.y, camera.transform.position.z);
        camera.transform.position = Vector3.SmoothDamp(camera.transform.position, targetPos, ref velocity, 0.01f);

    }
}
