public class WarriorFactory : CharacterFactory
{
    public override ICharacter CreateCharacter() => new Warrior();
}
