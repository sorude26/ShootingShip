using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    [SerializeField]
    Text currentScore;

    public void PrintScore(int score)
    {
        currentScore.text = "Score:" + score;
    }
}
