using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScore : MonoBehaviour
{
    [SerializeField]
    float interval;

    [SerializeField]
    ShowScore score;

    // Start is called before the first frame update

    public void SetScore(int score)
    {
        if (this.score)
        {
            this.score.PrintScore(score);
            StartCoroutine(Remove());
        }
    }
    IEnumerator Remove()
    {
        yield return new WaitForSeconds(interval);
        Destroy(this.gameObject);
    }
}
