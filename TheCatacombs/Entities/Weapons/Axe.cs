using TheCatacombs.UI;

namespace TheCatacombs.Entities.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; } = "Machado";
        public int Damage { get; } = 10;
        public int Weight { get; } = 10;

        public void Draw()
        {
            ConsoleUI.DisplayMessage(" _,-, ");
            ConsoleUI.DisplayMessage("T_  | ");
            ConsoleUI.DisplayMessage("||`-' ");
            ConsoleUI.DisplayMessage("||   ");
            ConsoleUI.DisplayMessage("||   ");
            ConsoleUI.DisplayMessage("~~   ");
        }
    }
}