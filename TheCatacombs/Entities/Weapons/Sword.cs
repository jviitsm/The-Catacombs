using TheCatacombs.UI;

namespace TheCatacombs.Entities.Weapons
{
    public class Sword : IWeapon
    {
        public string Name { get; } = "Espada";
        public int Damage { get; } = 8;
        public int Weight { get; } = 7;

        public void Draw()
        {
            ConsoleUI.DisplayMessage("    /");
            ConsoleUI.DisplayMessage("O===[====================-");
            ConsoleUI.DisplayMessage("    \\");

        }
    }
}