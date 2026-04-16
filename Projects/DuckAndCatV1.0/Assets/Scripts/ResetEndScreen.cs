using UnityEngine;

public class ResetEndScreen : MonoBehaviour
{
    public static ResetEndScreen instance;

    [SerializeField] private GameObject cat;
    [SerializeField] private GameObject duck;
  
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        resetEndScreen();
    }

    public void resetEndScreen()
    {
        cat.transform.position = new Vector3(-5.860003f,3.72f, 0f);
        duck.transform.position = new Vector3(-7.37f,3.75f, 0f);
    }
}
