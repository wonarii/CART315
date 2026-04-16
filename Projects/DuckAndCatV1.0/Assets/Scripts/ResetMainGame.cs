using UnityEngine;

public class ResetMainGame : MonoBehaviour
{
    public static ResetMainGame instance;

    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject duck;
    [SerializeField] private GameObject door1;
    [SerializeField] private GameObject lever;
    [SerializeField] private GameObject pitDoor;
  
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        resetMainGame();
    }

    public void resetMainGame()
    {
        cat.transform.position = new Vector3(4.58f,-3.2f, 0f);
        duck.transform.position = new Vector3(-8.36f,-3.03f, 0f);
        door1.transform.position = new Vector3(7.562f,-0.8601f, 0f);
        lever.transform.localPosition = new Vector3(0.28f,0.1574f, 0f);
        pitDoor.transform.position = new Vector3(61.1317f,-4.7429f, 0f);
    }
}
