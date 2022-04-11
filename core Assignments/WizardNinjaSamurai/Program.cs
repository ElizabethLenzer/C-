using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja Liz = new Ninja("Liz");
            Wizard Brittany = new Wizard("Brittany the great");
            Samurai Nathan = new Samurai("Samurai Nate");
            Nathan.Attack(Brittany);
            Brittany.Heal(Brittany);
            Nathan.Meditate();
            Liz.Attack(Nathan);
            Liz.Steal(Brittany);
            Brittany.Attack(Nathan);
            Nathan.Attack(Liz);
        }
    }
}