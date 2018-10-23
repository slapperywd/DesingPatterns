namespace SolidPrinciples.DependencyInversionPrinciple
{
    public class Ninja
    {
        private IWeapon _weapon;

        public Ninja(IWeapon weapon)
        {
            this._weapon = weapon;
        }

        public void Attack()
        {
            this._weapon.Attack();
        }
    }
}
