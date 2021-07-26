using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    [SerializeField]
    Text currentScore;
    [SerializeField]
    string text;

    public void PrintScore(int score)
    {
        currentScore.text = text + score;
    }
}
