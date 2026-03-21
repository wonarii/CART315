using UnityEngine;

public class Door1 : MonoBehaviour
{

    public static Door1 Door1Instance;
    [SerializeField] private GameObject door1;
    public float doorSpeed;
    void Awake()
    {
        Door1Instance = this;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openDoor()
    {
        if (door1.transform.position.x > 5.238)
        {
            door1.transform.position = new Vector3(door1.transform.position.x - doorSpeed, door1.transform.position.y, door1.transform.position.z);
        }
    }

    public void closeDoor()
    {
        if (door1.transform.position.x < 7.562)
        {
            door1.transform.position = new Vector3(door1.transform.position.x + doorSpeed, door1.transform.position.y, door1.transform.position.z);
        }
    }
    
    
}
