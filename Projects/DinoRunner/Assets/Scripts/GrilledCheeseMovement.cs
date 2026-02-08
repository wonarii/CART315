using UnityEngine;

public class GrilledCheeseMovement : MonoBehaviour
{
    
    private Transform grilledCheese;

    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        grilledCheese = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        grilledCheese.transform.position = new Vector3(grilledCheese.transform.position.x + speed, grilledCheese.transform.position.y, grilledCheese.transform.position.z);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        //is dino touching the ground?
        if (other.gameObject.tag == "WallLeft")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Player")
        {
            //getPoints();
            Destroy(this.gameObject);
        }
    }
}
