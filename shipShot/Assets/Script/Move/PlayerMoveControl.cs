using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveControl : MoveControl
{
    Rigidbody2D m_rB;
    /// <summary> 移動可能フラグ </summary>
    bool m_move;
    [Tooltip("移動速度")]
    [SerializeField] float m_moveSpeed = 2f;

    void Start()
    {
        m_rB = GetComponent<Rigidbody2D>();
        StartSet();
    }
    protected override void StartSet()
    {
        m_move = true;
    }
    
    void Update()
    {
        if (!m_move) 
        {
            transform.rotation = Quaternion.Euler(0, 0, 30);
            return; 
        }
        float h = Input.GetAxisRaw("Horizontal");
        m_rB.velocity = new Vector2(h * m_moveSpeed, 0);
    }

    public override void MoveStop()
    {
        m_rB.velocity = Vector2.zero;
        m_move = false;
    }
}
