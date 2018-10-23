namespace SolidPrinciples.DependencyInversionPrinciple
{
    using System;

    public class Katana : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attack with Katana.");
        }
    }
}
