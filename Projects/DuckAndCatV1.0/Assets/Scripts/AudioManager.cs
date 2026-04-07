using System;
using UnityEngine;
using Random = System.Random;

public class AudioManager : MonoBehaviour
{
  public static AudioManager instance;

  [SerializeField] private AudioSource[] duckWalk;
  [SerializeField] private AudioSource[] catWalk;
  private static bool catWalkPlaying = false;
  private static bool duckWalkPlaying = false;
  
  [SerializeField] private AudioSource catJump;
  [SerializeField] private AudioSource duckJump;

  [SerializeField] private AudioSource catClimb;

  [SerializeField] private AudioSource door;

  [SerializeField] private AudioSource waterSplash;
  
  [SerializeField] private AudioSource catRespawn;
  
  [SerializeField] private AudioSource buttonClick;
  
  [SerializeField] private AudioSource success;
  
  void Awake()
  {
    instance = this;
    
    DontDestroyOnLoad(this.gameObject);
  }

  public void playDuckWalk()
  {
    duckWalkPlaying = false;
    //check if any other walk is currently playing
    for (int i = 0; i < duckWalk.Length; i++)
    {
      if (duckWalk[i].isPlaying)
      {
        duckWalkPlaying = true;
      }
    }

    if (!duckWalkPlaying)
    {
      //randomizes the cat walk sounds
      Random randomizer = new Random();
      int randomIndex = randomizer.Next(duckWalk.Length);

      duckWalk[randomIndex].Play(0);
    }
  }

  public void playCatWalk()
  {
    catWalkPlaying = false;
    //check if any other walk is currently playing
    for (int i = 0; i < catWalk.Length; i++)
    {
      if (catWalk[i].isPlaying)
      {
        catWalkPlaying = true;
      }
    }

    if (!catWalkPlaying)
    {
      //randomizes the cat walk sounds
      Random randomizer = new Random();
      int randomIndex = randomizer.Next(catWalk.Length);

      catWalk[randomIndex].Play(0);
    }

  }
  
  public void playCatClimb()
  {
    
  }
  

  public void playCatJump()
  {
    catJump.Play(0);
  }

  public void playDuckJump()
  {
    duckJump.Play(0);
  }
  


  public void playDoor()
  {
    door.Play(0);
  }
  
  public void stopPlayDoor()
  {
    door.Stop();
  }

  public void playWaterSplash()
  {
    waterSplash.Play(0);
  }
  
  public void stopPlayWaterSplash()
  {
    waterSplash.Stop();
  }

  public void playCatRespawn()
  {
    catRespawn.Play(0);
  }

  public void playButtonClick()
  {
    buttonClick.Play(0);
  }

  public void playSuccess()
  {
    success.Play(0);
  }


 
}
