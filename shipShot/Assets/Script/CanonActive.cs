using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonActive : MonoBehaviour
{
    [SerializeField] GameObject ShellPrefab = default;
    [SerializeField] Transform Muzzle = default;
    AudioSource Audio = default;
    [SerializeField] Transform Crosshair = default;
    [SerializeField] float Interval = 1f;
    float m_timer;
    bool m_stop;
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        m_timer = Interval;
        EventManager.OnGameEnd += Stop;
    }

    void Update()
    {
        if (m_stop)
        {
            return;
        }
        m_timer += Time.deltaTime;
        if (Input.GetButtonDown("Fire1"))
        {
            if (m_timer > Interval)
            {
                m_timer = 0;
                Instantiate(ShellPrefab, Muzzle.position, this.transform.rotation);
            }

        }
        Vector2 x = Crosshair.transform.position - this.transform.position;
        this.transform.up = x;
    }
    private void Stop()
    {
        m_stop = true;
    }
}
