using System;

public class EventManager
{
    public static event Action OnGameEnd;

    public static void GameEnd()
    {
        OnGameEnd?.Invoke();
    }
}
