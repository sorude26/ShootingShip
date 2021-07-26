using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightMove : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    Rigidbody2D Rb = default;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        Rb.velocity = this.transform.up * Speed;
    }

}
