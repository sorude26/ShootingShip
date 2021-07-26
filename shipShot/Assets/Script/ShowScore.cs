using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    [SerializeField]
    public Text currentScore;
    [SerializeField]
    string text;

    public void PrintScore(int score)
    {
        if (score == 0)
        {
            currentScore.text = "";
            return;
        }
        currentScore.text = text + score;
    }
}
