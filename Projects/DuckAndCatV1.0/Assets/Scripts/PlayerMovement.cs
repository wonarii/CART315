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
        //we're gonna code each direction so it links to the proper function
        //walk left
        if (Input.GetKey(keycodeLeft)) walkLeft();
        //walk right
        if (Input.GetKey(keycodeRight)) walkRight();
        //jump
        if (Input.GetKey(keycodeUp)) jump();
        //down will be for special actions 
        if (Input.GetKey(keycodeDown)) down();
    }

    private void walkLeft()
    {
        Debug.Log("leftV");
        playerRb.linearVelocity = new Vector3(-speed, 0,0);
    }
    
    private void walkRight()
    {
        Debug.Log("rightV");
        playerRb.linearVelocity = new Vector3(speed, 0,0);
    }
    
    private void jump()
    {
        Debug.Log("jump");
        if (isTouchingGround)
        {
            
            //isTouchingGround = false;
        }
        
    }

    private void down()
    {
        Debug.Log("down");
    }
    
}
