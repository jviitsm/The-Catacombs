using TheCatacombs.UI;

namespace TheCatacombs.Entities.Monsters
{
    public class Goblin : Monster
    {
        public static class Factory
        {
            public static Goblin Create(string name, int health, int damage, Attributes attributes, IWeapon weapon, int positionX, int positionY)
            {
                return new Goblin(name, health, damage, attributes, weapon, positionX, positionY);
            }
        }

        private Goblin(string name, int health, int damage, Attributes attributes, IWeapon weapon, int positionX, int positionY)
         : base(name, health, damage, attributes, weapon, MonsterType.Goblin, positionX, positionY) { }


        public override void Draw()
        {
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣶⣿⣿⣶⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⢀⡼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢧⡀⠀⠀⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠢⣤⣀⡀⠀⠀⠀⢿⣧⣄⡉⠻⢿⣿⣿⡿⠟⢉⣠⣼⡿⠀⠀⠀⠀⣀⣤⠔⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠈⢻⣿⣶⠀⣷⠀⠉⠛⠿⠶⡴⢿⡿⢦⠶⠿⠛⠉⠀⣾⠀⣶⣿⡟⠁⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠻⣿⡆⠘⡇⠘⠷⠠⠦⠀⣾⣷⠀⠴⠄⠾⠃⢸⠃⢰⣿⠟⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠋⢠⣾⣥⣴⣶⣶⣆⠘⣿⣿⠃⣰⣶⣶⣦⣬⣷⡄⠙⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⢋⠛⠻⠿⣿⠟⢹⣆⠸⠇⣰⡏⠻⣿⠿⠟⠛⡙⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠈⢧⡀⠠⠄⠀⠈⠛⠀⠀⠛⠁⠀⠠⠄⢀⡼⠁⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⠈⢻⣿⣶⠆⣶⣦⡀⠘⠿⠶⡿⣶⣶⣆⠀⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣿⣿⠟⠋⠀⠀⠉⠛⠿⣿⣿⠟⠀⠀⠀⠀⠀⠀⠀");
            ConsoleUI.DisplayMessage("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");

        }
    }
}