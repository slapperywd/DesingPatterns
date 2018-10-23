namespace SolidPrinciples.LiskovSubstitutionPrinciple
{
    public class EngineStarter
    {
        public static void StartEngine(Vehicle vehicle)
        {
            vehicle.StartEngine();
        }
    }
}
