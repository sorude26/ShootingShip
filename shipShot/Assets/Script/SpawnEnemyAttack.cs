using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemyAttack : MonoBehaviour
{
    [SerializeField]
    GameObject enemyCannon;
    [SerializeField]
    float shotInterval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shot());
    }

    IEnumerator Shot()
    {
        yield return new WaitForSeconds(shotInterval);

        Instantiate(enemyCannon).transform.position = this.transform.position;
    }
}
