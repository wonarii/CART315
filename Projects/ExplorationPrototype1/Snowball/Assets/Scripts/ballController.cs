using UnityEngine;
using UnityEngine.InputSystem;

public class ballController : MonoBehaviour
{
    //package file for the move inputs stuff
    public InputActionAsset inputAction;
    //this is speed
    public float speed = 1.0f;
    //this is the sphere
    private Rigidbody rigid;
    //this is the move actions
    private InputAction move;
    //this is the snowball 
    public Transform ball;
    private float scale = 0.0001f;
    private Vector3 scaleVector = new Vector3(0.001f, 0.001f, 0.001f);


    void Start()
    {
        //finds the move inputs in the input package
        move = inputAction.FindAction("Move");
        //gets the sphere
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // FixedUpdate is called with a consistent delay every time
    void FixedUpdate()
    {
        //when move inputs are pressed
        if (move.IsPressed())
        {
            //give me value of thing pressed (vector 3 style!)
            Debug.Log(move.ReadValue<Vector2>());

            //move snowball in direction of arrows
            //multiply by delta time to avoid going to space
            //delta time is the time between computer frames
            //slows down everything based on your screen
            //ball.Translate(move.ReadValue<Vector2>().x*Time.deltaTime, 0, 0, Space.World);

            // ball.Translate(0, move.ReadValue<Vector2>().y * Time.deltaTime, 0, Space.World);

            //let's use the video instead for this
            if (move.ReadValue<Vector2>().x > 0)
            {
                //pushes the snowball
                rigid.AddForce(Vector3.right * speed);
            }
            else if (move.ReadValue<Vector2>().x < 0)
            {
                rigid.AddForce(-Vector3.right * speed);
            }

            if (move.ReadValue<Vector2>().y > 0)
            {
                rigid.AddForce(Vector3.forward * speed);
            }
            else if (move.ReadValue<Vector2>().y < 0)
            {
                rigid.AddForce(-Vector3.forward * speed);
            }

            rigid.mass += scale;
            ball.transform.localScale += scaleVector;
            
        }


    }
}
