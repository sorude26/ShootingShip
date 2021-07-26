using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] ShowScore m_socreView;
    int m_score = 0;
    private void Awake()
    {
        Instance = this;
    }
    public void GetScore(int score)
    {
        m_score += score;
        m_socreView.PrintScore(m_score);
    }
    public void GameOver()
    {
        EventManager.GameEnd();
        Debug.Log("GameOver");
    }
}
