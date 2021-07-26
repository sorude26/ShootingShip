using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell2 : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    Rigidbody2D Rb = default;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D Rb = GetComponent<Rigidbody2D>();
        Rb.velocity = this.transform.up * Speed;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
