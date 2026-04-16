using UnityEngine;

public class ResetStartScene : MonoBehaviour
{
  public static ResetStartScene instance;

  [SerializeField] private GameObject cat;
  [SerializeField] private GameObject duck;
  
  void Awake()
  {
    instance = this;
  }

  void Start()
  {
    resetStartScene();
  }

  public void resetStartScene()
  {
    cat.transform.position = new Vector3(6.32f,-2.93f, 0f);
    duck.transform.position = new Vector3(-9f,-3.53f, 0f);
  }
 
  
  
}
