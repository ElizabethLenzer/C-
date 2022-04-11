using System;

namespace WizardNinjaSamurai
{
    public class Wizard : Human
    {
        public Wizard(string name) : base(name)
        {
            Name = name;
            Intelligence = 25;
            health = 50;
        }
        public override int Attack(Human target)
        {
            int damage = Intelligence * 5;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            health += damage;
            return target.Health;
        }
        public int Heal(Human target)
        {
            int heal = Intelligence * 10;
            target.Health += heal;
            Console.WriteLine($"{Name} healed {target.Name} for {heal.ToString()} health!");
            return target.Health;
        }
    }
}