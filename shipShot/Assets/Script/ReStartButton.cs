using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReStartButton : MonoBehaviour
{
    
    public void timer()
    {
        Invoke("Restart", 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene("GameScene");
    }
}
