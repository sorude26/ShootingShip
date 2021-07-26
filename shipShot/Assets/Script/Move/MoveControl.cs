using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveControl : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.OnGameEnd += MoveStop;
    }
    protected abstract void StartSet();
    protected abstract void MoveStop();

}
