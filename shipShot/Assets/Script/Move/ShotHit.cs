using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotHit : MonoBehaviour
{
    [Tooltip("得点")]
    [SerializeField] int m_score = 100;
    [SerializeField] RemoveScore m_explosion;
    [SerializeField] GameObject m_dropItem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Shot")
        {
            GameManager.Instance.GetScore(m_score);
            var e = Instantiate(m_explosion);
            e.gameObject.transform.position = this.transform.position;
            e.SetScore(m_score);
            if (m_dropItem)
            {
                int r = Random.Range(0, 5);
                if (r > 2)
                {
                    Instantiate(m_dropItem).transform.position = this.transform.position;
                }
            }
            Destroy(collision);
            Destroy(this.gameObject);
            return;
        }
        if (collision.tag == "Player")
        {
            GameManager.Instance.PlayerDamge(); 
            var e = Instantiate(m_explosion);
            e.SetScore(0);
            e.gameObject.transform.position = this.transform.position;
            Destroy(this.gameObject);
            return;
        }
    }
}
