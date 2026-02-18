using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateScore(float score){
        scoreText.text = "Score: " + score;
    }
}
