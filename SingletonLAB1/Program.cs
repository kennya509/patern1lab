using System;

class Program
{
    static void Main()
    {
        GameManager gm1 = GameManager.GetInstance();
        GameManager gm2 = GameManager.GetInstance();

        gm1.SaveGame();

        Console.WriteLine(ReferenceEquals(gm1, gm2)); //true
    }
}
