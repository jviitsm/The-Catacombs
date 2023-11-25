using System;
using TheCatacombs.Entities;
using TheCatacombs.Entities.Weapons;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class CharacterManager
    {

        private GameManager gameManager;
        private RoomManager roomManager;
        private Player player;


        public CharacterManager(GameManager gameManager)
        {
            this.gameManager = gameManager;

        }

        public Player CreateCharacter()
        {
            roomManager = new RoomManager();
            string name = ChooseName();
            CharacterClass playerClass = ChooseClass();
            Room startingRoom = roomManager.GetRandomRoom();

            player = new Player(name, 100, playerClass.PreferredWeapon, playerClass, startingRoom);
            return player;
        }

        public void DisplayCharacterInfo()
        {

            ConsoleUI.DisplayMessage($"Nome: {player.Name}");
            ConsoleUI.DisplayMessage($"Vida: {player.CurrentHealth}/{player.MaxHealth}");
            ConsoleUI.DisplayMessage($"Força: {player.BaseAttributes.Strength}");
            ConsoleUI.DisplayMessage($"Destreza: {player.BaseAttributes.Dexterity}");
            ConsoleUI.DisplayMessage($"Inteligência: {player.BaseAttributes.Intelligence}");
            ConsoleUI.DisplayMessage($"Sabedoria: {player.BaseAttributes.Wisdom}");
            ConsoleUI.DisplayMessage($"Constituição: {player.BaseAttributes.Constitution}");
            ConsoleUI.DisplayMessage($"Carisma: {player.BaseAttributes.Charisma}");
            ConsoleUI.DisplayMessage($"Arma: {player.Weapon?.Name ?? "Nenhuma"}");

            ConsoleUI.DisplayMessage($"Sala: {player.CurrentRoom.Description} {player.CurrentRoom.X}, {player.CurrentRoom.Y}");

            ConsoleUI.DisplayMessage("Pressione qualquer tecla para continuar...");


        }

        private string ChooseName()
        {
            ConsoleUI.DisplayMessage("Escolha um nome para o seu personagem:");
            return ConsoleUI.GetUserInput();
        }

        private CharacterClass ChooseClass()
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
                case "1": return new CharacterClass("Guerreiro", new Attributes(15, 10, 10, 10, 10, 10), new Axe());
                case "2": return new CharacterClass("Mago", new Attributes(10, 10, 15, 10, 10, 10), new Staff());
                case "3": return new CharacterClass("Ladino", new Attributes(10, 15, 10, 10, 10, 10), new Dagger());
                case "4": return new CharacterClass("Clérigo", new Attributes(10, 10, 10, 15, 10, 10), new Dagger());
                case "5": return new CharacterClass("Bárbaro", new Attributes(15, 10, 10, 10, 10, 10), new Axe());
                case "6": return new CharacterClass("Druida", new Attributes(10, 10, 10, 10, 15, 10), new Staff());
                case "7": return new CharacterClass("Monge", new Attributes(10, 10, 10, 10, 10, 15), new Dagger());
                case "8": return new CharacterClass("Paladino", new Attributes(10, 10, 10, 10, 10, 10), new Dagger());
                case "9": return new CharacterClass("Patrulheiro", new Attributes(10, 10, 10, 10, 10, 10), new Dagger());
                case "0": return null;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    return ChooseClass();
            }
        }

        private Attributes GetAttributesForClass(CharacterClass characterClass)
        {
            return characterClass?.BaseAttributes ?? new Attributes();
        }

        private IWeapon GetWeaponForClass(CharacterClass characterClass)
        {
            return characterClass?.PreferredWeapon ?? new Sword(); // Substitua DefaultWeapon pelo seu tipo de arma padrão
        }
    }
}
