using UnityEngine;

public class basketManager : MonoBehaviour
{
    //inputs
    public KeyCode left;
    public KeyCode right;

    //basket position
    public float basketX, basketY;
    //basket speed
    public float basketSpeed = 0.03f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //when you press the left key
        if (Input.GetKey(left))
        {
            //move left
            basketX -= basketSpeed;
        }
        //when you press the right key
        if (Input.GetKey(right))
        {
            //move right
            basketX += basketSpeed;
        }

        transform.position = new Vector3(basketX, -4.0f, 0);
    }
}
