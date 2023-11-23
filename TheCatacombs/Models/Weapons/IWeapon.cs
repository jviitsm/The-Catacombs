namespace TheCatacombs.Models
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
        int Weight { get; }

    }
}