using UnityEngine;

public class AudioManager : MonoBehaviour
{


    public static AudioManager AM;

    [SerializeField] private AudioSource nyom;

    [SerializeField] private AudioSource jump;

    void Awake(){
        AM = this;
    }
   
    public void playNyom(){
        nyom.Play(0);
    }

    public void playJump(){
        jump.Play(0);
    }

}
