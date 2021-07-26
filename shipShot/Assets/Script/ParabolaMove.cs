using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParabolaMove : MoveControl
{
    [SerializeField] float m_speed = 5f;
    Rigidbody2D m_rb = default;
    bool m_move;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        StartSet();
    }
    private void Update()
    {
        if (!m_move)
        {
            m_rb.velocity = Vector2.zero;
        }
    }
    public override void MoveStop()
    {
        m_move = false;
        m_rb.velocity = Vector2.zero;
    }

    protected override void StartSet()
    {
        m_move = true;
        m_rb.velocity = this.transform.up * m_speed;
    }
}
