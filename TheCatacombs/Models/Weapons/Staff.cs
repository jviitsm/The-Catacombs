namespace TheCatacombs.Models.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; } = "Cajado";
        public int Damage { get; } = 5;
        public int Weight { get; } = 3;
    }
}