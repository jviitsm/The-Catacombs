using System.ComponentModel;
using TheCatacombs.Models;
using TheCatacombs.Models.Weapons;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class CharacterManager
    {
        private IWeapon weapon;
        private Attributes playerAttributes;


        public Player CreateCharacter()
        {
            var name = ChooseName();
            ChooseClass();
            Player player = new Player(name, 100, playerAttributes, weapon);

            return player;
        }

        public static void DisplayCharacterInfo(Player player)
        {
            ConsoleUI.DisplayMessage($"Nome: {player.Name}");
            ConsoleUI.DisplayMessage($"Vida: {player.CurrentHealth}/{player.MaxHealth}");
            ConsoleUI.DisplayMessage($"Força: {player.Attributes.Strength}");
            ConsoleUI.DisplayMessage($"Destreza: {player.Attributes.Dexterity}");
            ConsoleUI.DisplayMessage($"Inteligência: {player.Attributes.Intelligence}");
            ConsoleUI.DisplayMessage($"Sabedoria: {player.Attributes.Wisdom}");
            ConsoleUI.DisplayMessage($"Constituição: {player.Attributes.Constitution}");
            ConsoleUI.DisplayMessage($"Carisma: {player.Attributes.Charisma}");
            ConsoleUI.DisplayMessage($"Arma: {player.Weapon?.Name ?? "Nenhuma"}");
        }

        private string ChooseName()
        {
            ConsoleUI.DisplayMessage("Escolha um nome para o seu personagem:");
            return ConsoleUI.GetUserInput();
        }

        private void ChooseClass()
        {
            ConsoleUI.DisplayMessage("Escolha uma classe:");
            ConsoleUI.DisplayMessage("1 - Guerreiro");
            ConsoleUI.DisplayMessage("2 - Mago");
            ConsoleUI.DisplayMessage("3 - Ladino");
            ConsoleUI.DisplayMessage("4 - Clérigo");
            ConsoleUI.DisplayMessage("5 - Bárbaro");
            ConsoleUI.DisplayMessage("6 - Druida");
            ConsoleUI.DisplayMessage("7 - Monge");
            ConsoleUI.DisplayMessage("8 - Paladino");
            ConsoleUI.DisplayMessage("9 - Patrulheiro");
            ConsoleUI.DisplayMessage("0 - Sair");

            string input = ConsoleUI.GetUserInput();

            switch (input)
            {
                case "1":
                    playerAttributes = new Attributes(15, 10, 10, 10, 10, 10);
                    weapon = new Axe();
                    break;
                case "2":
                    playerAttributes = new Attributes(10, 10, 15, 10, 10, 10);
                    weapon = new Staff();
                    break;
                case "3":
                    playerAttributes = new Attributes(10, 15, 10, 10, 10, 10);
                    weapon = new Dagger();
                    break;
                case "4":
                    playerAttributes = new Attributes(10, 10, 10, 15, 10, 10);
                    weapon = new Dagger();
                    break;
                case "5":
                    playerAttributes = new Attributes(15, 10, 10, 10, 10, 10);
                    weapon = new Dagger();
                    break;
                case "6":
                    playerAttributes = new Attributes(10, 10, 10, 10, 15, 10);
                    weapon = new Dagger();
                    break;
                case "7":
                    playerAttributes = new Attributes(10, 10, 10, 10, 10, 15);
                    weapon = new Dagger();
                    break;
                case "8":
                    playerAttributes = new Attributes(10, 10, 10, 10, 10, 10);
                    weapon = new Dagger();
                    break;
                case "9":
                    playerAttributes = new Attributes(10, 10, 10, 10, 10, 10);
                    weapon = new Dagger();
                    break;
                case "0":
                    break;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    ChooseClass();
                    break;
            }
        }
    }
}
