using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
    [SerializeField] float[] m_spawnSpeed;
    [SerializeField] float[] m_spawnTime;
    [SerializeField] SpawnControl[] m_enemySpwanCon;
    [SerializeField] float m_speedUpSpeed = 0.05f;
    float[] m_allSpawnSpeed;
    float[] Timers;
    bool m_spawn = false;
    private void Start()
    {
        EventManager.OnGameEnd += StopSpawn;
        EventManager.OnGameStart += StartSpawn;
        Timers = new float[m_spawnSpeed.Length];
        m_allSpawnSpeed = new float[m_spawnSpeed.Length];
        for (int i = 0; i < m_allSpawnSpeed.Length; i++)
        {
            m_allSpawnSpeed[i] = 1f;
        }
    }
    void Update()
    {
        if (!m_spawn) return;
        for (int i = 0; i < Timers.Length; i++)
        {
            Timers[i] += m_spawnSpeed[i] * m_allSpawnSpeed[i] * Time.deltaTime;
            if (Timers[i] >= m_spawnTime[i])
            {
                m_enemySpwanCon[i].Spawn();
                Timers[i] = 0;
                m_allSpawnSpeed[i] += m_speedUpSpeed;
            }
        }
    }
    void StopSpawn()
    {
        m_spawn = false;
        for (int i = 0; i < Timers.Length; i++)
        {
            Timers[i] = 0;
        }
        for (int i = 0; i < m_allSpawnSpeed.Length; i++)
        {
            m_allSpawnSpeed[i] = 1f;
        }
    }
    void StartSpawn()
    {
        m_spawn = true;
    }
}
