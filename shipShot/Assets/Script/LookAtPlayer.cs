using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    GameObject playerObj;
    Vector3 toPlayer;

    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        toPlayer = (playerObj.transform.position - this.transform.position).normalized;
        this.transform.up = toPlayer;
    }
}
