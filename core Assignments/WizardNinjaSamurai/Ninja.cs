using System;
namespace WizardNinjaSamurai
{
    public class Ninja: Human
    {
        public Ninja(string name): base(name)
        {
            Name = name;
            Dexterity = 175;
        }
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int critical = rand.Next (0,100);
            int damage = 0;
            if (critical <=20)
            {
                damage = 10 + (Dexterity * 5);
            }
            else
            {
                damage = Dexterity * 5;
            }
            target.Health -= damage;
            Console.WriteLine($"{Name} stole 5 health from {target.Name}!");
            return target.Health;
        }
        public int Steal(Human target)
        {
            target.Health -= 5;
            Health += 5;
            Console.WriteLine($"{Name} stole 5 health from {target.Name}!");
            return target.Health;
        }
    }
}