using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveControl : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnGameEnd += MoveStop;
    }
    private void OnDisable()
    {
        EventManager.OnGameEnd -= MoveStop;
    }
    protected abstract void StartSet();
    public abstract void MoveStop();

}
