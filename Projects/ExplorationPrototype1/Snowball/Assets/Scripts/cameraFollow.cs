using UnityEngine;

public class cameraFollow : MonoBehaviour
{
   //this is the snowball that we are following around
    public Transform target;
    //offset the camera has with the target (snowball)
    private Vector3 offset;

    //called once when the program starts
    private void Start()
    {
        //camera's current position - snowball's current position
        offset = transform.position - target.position;
    }

    //called every frame
    private void Update()
    {
        //moves the camera to match the snoball's position
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
    }
}
