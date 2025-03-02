public class SwordBuilder : IWeaponBuilder
{
    private Weapon _weapon = new Weapon();

    public void SetName(string name) => _weapon.Name = name;
    public void SetDamage(int damage) => _weapon.Damage = damage;
    public void SetElement(string element) => _weapon.Element = element;

    public Weapon GetResult() => _weapon;
}
