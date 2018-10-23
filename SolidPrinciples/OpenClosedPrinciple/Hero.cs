namespace SolidPrinciples.OpenClosedPrinciple
{
    public class Hero
    {
        protected int BaseDamage { get; set; } = 25;

        public virtual int CalculateTotalDamage()
        {
            return this.BaseDamage + 10; // let's say that a hero has 10 additional bonus damage
        }
    }
}
