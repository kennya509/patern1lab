using System;

public class GameManager
{
    private static GameManager instance;
    private static readonly object lockObject = new object();

    private GameManager() { }

    public static GameManager GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
            }
        }
        return instance;
    }

    public void SaveGame()
    {
        Console.WriteLine("Гру збережено!");
    }
}
