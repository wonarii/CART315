using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    //the player
    [SerializeField] Rigidbody2D playerRb;
    //player speed
    public float speed;
    public float jumpForce;
    
    //check if the player is touching a platform
    private bool isTouchingGround;
    
    //making the public fields for the controls
    public KeyCode keycodeLeft;
    public KeyCode keycodeRight;
    public KeyCode keycodeUp;
    public KeyCode keycodeDown;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //we need to calculate the direction
        float inputX = 0;
        float inputY = 0;
        //walk left
        if (Input.GetKey(keycodeLeft))
        {
            inputX = -1;
        }
        //walk right
        if (Input.GetKey(keycodeRight))
        {
            inputX = 1;
        }
        //jump
        if (Input.GetKey(keycodeUp))
        {
            inputY = 1;
        }
        //down will be for special actions 
        if (Input.GetKey(keycodeDown))
        {
            inputY = -1;
        }

        if (Mathf.Abs(inputX) > 0)
        {
            playerRb.linearVelocity = new Vector2(inputX*speed, playerRb.linearVelocity.y);
        }
        if (Mathf.Abs(inputY) > 0)
        {
            playerRb.linearVelocity = new Vector2(playerRb.linearVelocity.x, inputY*jumpForce);
        }

    }

   
}
