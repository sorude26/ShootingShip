using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotHit : MonoBehaviour
{
    [Tooltip("得点")]
    [SerializeField] int m_score = 100;
    [SerializeField] RemoveScore m_explosion;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shot")
        {
            GameManager.Instance.GetScore(m_score);
            var e = Instantiate(m_explosion);
            e.gameObject.transform.position = this.transform.position;
            e.SetScore(m_score);
            Destroy(collision);
            Destroy(this.gameObject);
        }
        if (collision.tag == "Player")
        {
            GameManager.Instance.GameOver();
        }
    }
}
