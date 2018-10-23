namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    using System;

    public class Bus : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bus engine is started");        
        }
    }
}
