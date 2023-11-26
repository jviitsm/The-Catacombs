using TheCatacombs.UI;

namespace TheCatacombs.Entities.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; } = "Machado";
        public int Damage { get; } = 10;
        public int Weight { get; } = 10;

        public static class Factory
        {
            public static Axe Create()
            {
                return new Axe();
            }
        }

        private Axe() { }

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