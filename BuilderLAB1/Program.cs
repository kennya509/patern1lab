using System;
class Program
{  static void Main()
    {
        IWeaponBuilder builder = new SwordBuilder();
        Blacksmith blacksmith = new Blacksmith();
        blacksmith.MakeFireSword(builder);

        Weapon weapon = builder.GetResult();
        weapon.Show();
    }
}
