using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text text;
    public int score = 0;
    

    void Update()
    {

        text.text = "Your Coins: " + score.ToString();
    }

    public void GetScore()
    {
        score+=50;

    }
}
