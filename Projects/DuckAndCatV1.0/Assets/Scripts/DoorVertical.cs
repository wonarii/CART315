using UnityEngine;

public class DoorVertical : MonoBehaviour
{
    public static DoorVertical doorVerticalInstance;

    [SerializeField] private GameObject door;
    public float doorSpeed;
    [SerializeField] private float startY;
    [SerializeField] private float endY;

    void Awake()
    {
        doorVerticalInstance = this;
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
        Debug.Log("OPENN");
        if (door.transform.position.y < endY)
        {
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + doorSpeed,
                door.transform.position.z);
        }
        else
        {
            //door sound
            AudioManager.instance.stopPlayDoor2();
        }
    }

    public void closeDoor()
    {
        Debug.Log("CLOSE");
        if (door.transform.position.y > startY)
        {
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - doorSpeed,
                door.transform.position.z);
        }
        else
        {
            //door sound
            AudioManager.instance.stopPlayDoor2();
        }
    }
}