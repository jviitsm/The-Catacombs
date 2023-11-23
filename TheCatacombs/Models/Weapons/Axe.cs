namespace TheCatacombs.Models.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; } = "Machado";
        public int Damage { get; } = 10;
        public int Weight { get; } = 10;
    }
}