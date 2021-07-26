using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float m_initialSpeed = 5f;
    [SerializeField] GameObject m_effectPrefab = default;
    void Start()
    {
        // Rigidbody を取得して発射する
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = this.transform.up * m_initialSpeed;
    }

    void Update()
    {
        // 下に落ちたら自分自身を破棄する
        if (this.transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Rock" || collision.gameObject.tag == "Shell")
        {
            Instantiate(m_effectPrefab, this.transform.position, this.transform.rotation);
        }
        // 何かにぶつかったら自分自身を破棄する
        Destroy(this.gameObject);
    }
}
