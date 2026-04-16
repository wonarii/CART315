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
    AudioManager.instance.playButtonClick();
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
  
  public void exitGame()
  {
    AudioManager.instance.playButtonClick();
    Debug.Log("Goodbye!");
    Application.Quit();
  }

  public void restartGame()
  {
    AudioManager.instance.playButtonClick();
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
  }
  
}
