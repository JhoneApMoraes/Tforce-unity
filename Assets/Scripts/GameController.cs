using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public bool PlayerIsAlive;
    public int Score;
    public int CoinScore;
    public Text coinText;
    public Text scoreText;
    public float ScorePerSecond;
    public static GameController current;

    void Start()
    {
        current = this;
        PlayerIsAlive = true;
    }

    float ScoreUpdate;
    void Update()
    {
        if (PlayerIsAlive)
        {
        
            ScoreUpdate += ScorePerSecond * Time.deltaTime;
            Score = (int)ScoreUpdate;
            scoreText.text = Score.ToString("00000");
        }
    }

    public void AddScore(int value){
        CoinScore += value;
        coinText.text = CoinScore.ToString("00000");
    }
}
