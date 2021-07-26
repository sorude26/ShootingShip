using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveScore : MonoBehaviour
{
    [SerializeField]
    float interval;

    ShowScore score;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<ShowScore>();
        StartCoroutine(Remove());
    }

    IEnumerator Remove()
    {
        yield return new WaitForSeconds(interval);
        score.currentScore.text = "";
    }
}
