using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static float points;
    public static GameManager GM;


    void Awake(){
        GM = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        reset();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void reset(){
        points = 0;
    }

    public void eatGrilledCheese(){
        points ++;

    }
}
