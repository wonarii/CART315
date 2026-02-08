using System;
using UnityEngine;

public class dinoMovement : MonoBehaviour
{
    private Rigidbody2D dinoRB;
    private bool isTouchingGround;

    public float dinoSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dinoRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0)) jump();
    }

    private void jump()
    {
        if (isTouchingGround)
        {
            // Add a vertical force
            dinoRB.AddForce(transform.up * dinoSpeed);
            isTouchingGround = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
       
        //is dino touching the ground?
        if (other.gameObject.tag == "Floor")
        {
            isTouchingGround = true;
        }
    }
}
