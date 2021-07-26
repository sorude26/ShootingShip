using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    [SerializeField] ShowScore m_socreView;
    [SerializeField] ShowLife m_life;
    int m_score = 0;
    int m_playerLife = 3;
    [SerializeField] GameObject m_gameOverUI;
    private void Awake()
    {
        Instance = this;
        m_gameOverUI.SetActive(false);
    }
    public void GetScore(int score)
    {
        m_score += score;
        m_socreView.PrintScore(m_score);
    }
    public void GameStart()
    {
        m_playerLife = 3;
        EventManager.GameStart();
    }
    public void GameOver()
    {
        EventManager.GameEnd();
        m_gameOverUI.SetActive(true);
    }
    public void PlayerDamge()
    {
        m_playerLife--;
        if (m_playerLife <= 0)
        {
            GameOver();
            m_playerLife = 0;
        }
        m_life.SetLife(m_playerLife);
    }
    public void LifeUp()
    {
        m_playerLife++;
        if (m_playerLife > 3)
        {
            m_playerLife = 3;
        }
        m_life.SetLife(m_playerLife);
    }
}
