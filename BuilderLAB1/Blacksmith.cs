public class Blacksmith
{
    public void MakeFireSword(IWeaponBuilder builder)
    {
        builder.SetName("Вогняний меч");
        builder.SetDamage(50);
        builder.SetElement("Вогонь");
    }
}
