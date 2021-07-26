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
    void Start()
    {
        Audio = GetComponent<AudioSource>();
        m_timer = Interval;
    }

    void Update()
    {
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
}
