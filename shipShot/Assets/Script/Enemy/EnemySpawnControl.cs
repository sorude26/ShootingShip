using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnControl : MonoBehaviour
{
    [SerializeField] float[] m_spawnSpeed;
    [SerializeField] float[] m_spawnTime;
    [SerializeField] SpawnControl[] m_enemySpwanCon;
    float[] Timers;
    bool m_spawn = true;
    private void Start()
    {
        EventManager.OnGameEnd += StopSpawn;
        Timers = new float[m_spawnSpeed.Length];
    }
    void Update()
    {
        if (!m_spawn) return;
        for (int i = 0; i < Timers.Length; i++)
        {
            Timers[i] += m_spawnSpeed[i] * Time.deltaTime;
            if (Timers[i] >= m_spawnTime[i])
            {
                m_enemySpwanCon[i].Spawn();
                Timers[i] = 0;
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
    }
}
