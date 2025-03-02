using System;

public class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
    public string Element { get; set; }

    public void Show()
    {
        Console.WriteLine($"Зброя: {Name}, Урон: {Damage}, Елемент: {Element}");
    }
}
