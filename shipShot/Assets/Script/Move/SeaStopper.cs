using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaStopper : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SeaSurface")
        {
            var move = this.gameObject.GetComponent<MoveControl>();
            move.MoveStop();
        }
    }
}
