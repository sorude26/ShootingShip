using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowLife : MonoBehaviour
{
    [SerializeField]
    GameObject[] life;

    public void SetLife(int l)
    {
        foreach (var item in life)
        {
            item.SetActive(false);
        }

        if(l > life.Length)
        {
            return;
        }

        for (int i = 0; i < l; i++)
        {
            life[i].SetActive(true);
        }
    }
}
