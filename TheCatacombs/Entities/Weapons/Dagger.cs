using TheCatacombs.UI;

namespace TheCatacombs.Entities.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; } = "Adaga";
        public int Damage { get; } = 5;
        public int Weight { get; } = 3;

        public void Draw()
        {
            ConsoleUI.DisplayMessage("       .---.       ");
            ConsoleUI.DisplayMessage("       |---|       ");
            ConsoleUI.DisplayMessage("       |---|       ");
            ConsoleUI.DisplayMessage("       |---|       ");
            ConsoleUI.DisplayMessage("   .---^ - ^---.   ");
            ConsoleUI.DisplayMessage("   :___________:   ");
            ConsoleUI.DisplayMessage("      |  |//|      ");
            ConsoleUI.DisplayMessage("      |  |//|      ");
            ConsoleUI.DisplayMessage("      |  |//|      ");
            ConsoleUI.DisplayMessage("      |  |//|      ");
            ConsoleUI.DisplayMessage("      |  |//|      ");
            ConsoleUI.DisplayMessage("      |  |//|      ");
            ConsoleUI.DisplayMessage("      |  |.-|      ");
            ConsoleUI.DisplayMessage("      |.-'**|      ");
            ConsoleUI.DisplayMessage("       \\***/       ");
            ConsoleUI.DisplayMessage("        \\*/        ");
            ConsoleUI.DisplayMessage("         V          ");
        }
    }
}