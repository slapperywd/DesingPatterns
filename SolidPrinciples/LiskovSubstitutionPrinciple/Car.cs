namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    using System;

    public class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine is started");
        }
    }
}
