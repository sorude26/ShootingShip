using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SelectDirMove : MoveControl
{ 
    [SerializeField] float m_speed = 5f;
    Rigidbody2D m_rb = default;
    [SerializeField] Vector2 Dir = new Vector2(1f, 0f);
    bool m_move;
    void Start()
    {
        m_rb = GetComponent<Rigidbody2D>();
        StartSet();
    }

    void Update()
    {
        if (!m_move)
        {
            m_rb.velocity = Vector2.zero;
            return; 
        }
        m_rb.velocity =m_speed * Dir;
    }

    public override void MoveStop()
    {
        m_move = false;
        m_rb.velocity = Vector2.zero;
    }

    protected override void StartSet()
    {
        m_move = true;
    }

}
