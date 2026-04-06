using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
  
  public static SceneChanger instance;

  void Awake()
  {
    instance = this;
  }
  public void changeToEndScreen()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  
  public void changeToMainGame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  
  public void exitGame()
  {
    Debug.Log("Goodbye!");
    Application.Quit();
  }
  
}
