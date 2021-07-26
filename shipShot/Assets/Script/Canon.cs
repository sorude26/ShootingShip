using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] GameObject m_shellPrefab = default;
    [SerializeField] Transform m_muzzle = default;
    AudioSource m_audio = default;
    [SerializeField] Transform m_Crosshair = default;
    [SerializeField] float m_interval = 1f;
    float m_timer;
    void Start()
    {
        m_audio = GetComponent<AudioSource>();
        m_timer = m_interval;
    }

    void Update()
    {
        m_timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            if (m_timer > m_interval)
            {
                m_timer = 0;
                Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
            }

        }
        Vector2 x = m_Crosshair.transform.position - this.transform.position;
        this.transform.up = x;
    }
}
