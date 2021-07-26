using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotHit : MonoBehaviour
{
    [Tooltip("得点")]
    [SerializeField] int m_score = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shot")
        {
            GameManager.Instance.GetScore(m_score);
            Destroy(collision);
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            GameManager.Instance.GameOver();
        }
    }
}
