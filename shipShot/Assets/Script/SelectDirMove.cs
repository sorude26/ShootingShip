using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SelectDirMove : MonoBehaviour
{
    [SerializeField] float Speed = 5f;
    Rigidbody2D Rb = default;
    [SerializeField] Vector2 Dir = new Vector2(1f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rb.velocity =Speed * Dir;
    }
}
