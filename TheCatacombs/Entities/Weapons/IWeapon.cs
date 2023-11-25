namespace TheCatacombs.Entities
{
    public interface IWeapon
    {
        string Name { get; }
        int Damage { get; }
        int Weight { get; }

        void Draw();

    }
}