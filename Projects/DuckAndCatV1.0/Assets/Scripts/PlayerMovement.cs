using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    //package file for the move inputs stuff
    public InputActionAsset inputAction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //finds the move inputs in the input package
        move = inputAction.FindAction("Move");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
