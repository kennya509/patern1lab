using System;

class Program
{
    static void Main()
    {
        CharacterFactory factory = new WarriorFactory();
        ICharacter character = factory.CreateCharacter();
        character.Attack();
    }
}
