namespace TheCatacombs.Models.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; } = "Adaga";
        public int Damage { get; } = 5;
        public int Weight { get; } = 3;
    }
}