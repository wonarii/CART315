using System;
using UnityEngine;

public class buttonHold : MonoBehaviour
{
    [SerializeField] private GameObject button;
    [SerializeField] private float buttonDownY;
    [SerializeField] private float buttonUpY;
    [SerializeField] private float buttonSpeed;
    private bool buttonHeld = false;
    private static int oneButtonHeld = 0;

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
        if (buttonHeld)
        {
            lowerButton();
        }
        else
        {
            raiseButton();
        }

        if (button.transform.position.y <= buttonDownY)
        {
            DoorVertical.doorVerticalInstance.openDoor();
        }
        else if (oneButtonHeld == 0)
        {
            DoorVertical.doorVerticalInstance.closeDoor();
        }
    }

    private void lowerButton()
    {
        //lower button
        if (button.transform.position.y > buttonDownY)
        {
            button.transform.position = new Vector3(button.transform.position.x,
                button.transform.position.y - buttonSpeed, button.transform.position.z);
        }
    }

    private void raiseButton()
    {
        if (button.transform.position.y < buttonUpY)
        {
            button.transform.position = new Vector3(button.transform.position.x,
                button.transform.position.y + buttonSpeed, button.transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        buttonHeld = true;
        oneButtonHeld ++;

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        buttonHeld = false;
        oneButtonHeld --;

    }
}
