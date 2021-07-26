using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    [SerializeField] float m_movePower = 5f;
    float Horizon;
    Rigidbody2D Rb = default;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Horizon = Input.GetAxisRaw("Horizontal");
        Rb.velocity = new Vector2(m_movePower * Horizon, Rb.velocity.y);
    }
}
