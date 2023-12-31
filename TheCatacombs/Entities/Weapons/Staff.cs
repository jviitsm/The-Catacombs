using TheCatacombs.UI;

namespace TheCatacombs.Entities.Weapons
{
    public class Staff : IWeapon
    {
        public string Name { get; } = "Cajado";
        public int Damage { get; } = 5;
        public int Weight { get; } = 3;

        public static class Factory
        {
            public static Staff Create()
            {
                return new Staff();
            }
        }

        private Staff() { }

        public void Draw()
        {
            ConsoleUI.DisplayMessage(" .||,  ");
            ConsoleUI.DisplayMessage("\\.`',/");
            ConsoleUI.DisplayMessage("= ,. = ");
            ConsoleUI.DisplayMessage("/ || \\");
            ConsoleUI.DisplayMessage("  || ");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
            ConsoleUI.DisplayMessage("  ||");
        }
    }
}