using System;

public class EventManager
{
    public static event Action OnGameEnd;
    public static event Action OnGameStart;
    public static void GameEnd()
    {
        OnGameEnd?.Invoke();
    }
    public static void GameStart()
    {
        OnGameStart?.Invoke();
    }
}
