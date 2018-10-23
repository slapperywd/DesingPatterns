namespace SolidPrinciples.DependencyInversionPrinciple
{
    using System;

    public class Sword : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Attack with sword");
        }
    }
}
