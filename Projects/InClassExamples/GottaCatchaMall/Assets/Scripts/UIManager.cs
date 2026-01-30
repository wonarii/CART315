using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public int score;
    public TMP_Text scoreText;

    //singleton
    public static UIManager S;

    //happens before start
    void Awake()
    {
        S = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore(0);
    }

    // Update is called once per frame
    public void UpdateScore(int pointValue)
    {
        //how much are we updating the score by?
        int _pointValue = pointValue;
        //add / substract that value
        score += _pointValue;
        //make that new value a String
        string scoreString = score.ToString();
        //change the scoreText to the new string
        scoreText.text = "Score: " + scoreString;
    }
}
