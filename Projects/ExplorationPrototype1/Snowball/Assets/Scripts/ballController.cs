using UnityEngine;
using UnityEngine.InputSystem;

public class ballController : MonoBehaviour
{
    //package file for the move inputs stuff
    public InputActionAsset inputAction;
    //this is speed
    public float speed = 3.0f;
    //this is the move actions
    private InputAction move;

    void Start()
    {
        //finds the move inputs in the input package
        move = inputAction.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        //when move inputs are pressed
        if (move.IsPressed())
        {
            //give me value of thing pressed (vector 3 style!)
            Debug.Log(move.ReadValue<Vector2>());
        }
    }
}
