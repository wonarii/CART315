using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  public static AudioManager instance;

  [SerializeField] private AudioSource[] duckWalk;
  [SerializeField] private AudioSource[] catWalk;
  
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
  }

  public void playDuckWalk()
  {
    //randomizes the duck walk sounds
  }

  public void playCatWalk()
  {
    //randomizes the cat walk sounds
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
