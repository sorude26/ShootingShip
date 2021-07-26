using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    [SerializeField] Transform[] m_spawnPoints;
    [SerializeField] GameObject[] m_spwanObjects;
    public void Spawn()
    {
        int eR = Random.Range(0, m_spwanObjects.Length);
        int tR = Random.Range(0, m_spawnPoints.Length);
        Instantiate(m_spwanObjects[eR]).transform.position = m_spawnPoints[tR].position;
    }
}
