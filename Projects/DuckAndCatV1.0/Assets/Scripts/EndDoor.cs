using UnityEngine;
using UnityEngine.Rendering.Universal;

public class EndDoor : MonoBehaviour
{
    public static bool catInPosition = false;
    public static bool duckInPosition = false;

    public static EndDoor endDoorInstance;

    [SerializeField] private GameObject door;
    [SerializeField] private float yStart;
    [SerializeField] private float yEnd;
    [SerializeField] private float doorSpeed;

    [SerializeField] private Light2D light;
    [SerializeField] private float lightMax;
    [SerializeField] private float lightSpeed;
    
    void Awake()
    {
        endDoorInstance = this;
    }

    void openDoor()
    {
        if (door.transform.position.y > yEnd)
        {
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - doorSpeed,
                door.transform.position.z);
        }

        if (light.intensity < lightMax)
        {
            light.intensity += lightSpeed;
            Debug.Log(light.intensity);
        }
        
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (catInPosition && duckInPosition)
        {
            openDoor();
        }
    }
}
