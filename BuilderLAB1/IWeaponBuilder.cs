public interface IWeaponBuilder
{
    void SetName(string name);
    void SetDamage(int damage);
    void SetElement(string element);
    Weapon GetResult();
}
