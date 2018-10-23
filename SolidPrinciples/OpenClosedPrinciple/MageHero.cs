namespace SolidPrinciples.OpenClosedPrinciple
{
    public class MageHero : Hero
    {
        public MageHero()
        {
            this.BaseDamage = 40;
        }

        public override int CalculateTotalDamage()
        {
            return this.BaseDamage + 40; //40 bonus damage for Mage
        }
    }
}
