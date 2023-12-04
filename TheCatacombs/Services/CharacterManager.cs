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

            player = Player.Factory.Create(name, playerClass.PreferredWeapon, playerClass, startingRoom);
            return player;
        }

        public void DisplayCharacterInfo()
        {

            ConsoleUI.DisplayMessage($"Nome: {player.Name}");
            ConsoleUI.DisplayMessage($"Level: {player.Level}");
            ConsoleUI.DisplayMessage($"Vida: {player.CurrentHealth}/{player.MaxHealth}");
            ConsoleUI.DisplayMessage($"Força: {player.BaseAttributes.Strength}");
            ConsoleUI.DisplayMessage($"Destreza: {player.BaseAttributes.Dexterity}");
            ConsoleUI.DisplayMessage($"Inteligência: {player.BaseAttributes.Intelligence}");
            ConsoleUI.DisplayMessage($"Sabedoria: {player.BaseAttributes.Wisdom}");
            ConsoleUI.DisplayMessage($"Constituição: {player.BaseAttributes.Constitution}");
            ConsoleUI.DisplayMessage($"Carisma: {player.BaseAttributes.Charisma}");
            DisplayWeaponInfo();

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
                case "1": return CreateWarrior();
                case "2": return CreateWizard();
                case "3": return CreateRogue();
                case "4": return CreateCleric();
                case "5": return CreateBarbarian();
                case "6": return CreateDruid();
                case "7": return CreateMonk();
                case "8": return CreatePaladin();
                case "9": return CreateRanger();
                case "0": return null;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    return ChooseClass();
            }
        }

        public void DisplayWeaponInfo()
        {
            ConsoleUI.DisplayMessage($"Arma: {player.Weapon?.Name}");
            ConsoleUI.DisplayMessage($"Dano: {player.Weapon?.Damage}");
            ConsoleUI.DisplayMessage($"Peso: {player.Weapon?.Weight}");
            player.Weapon?.Draw();
            ConsoleUI.DisplayMessage("Pressione qualquer tecla para continuar...");
        }

        private static CharacterClass CreateWarrior()
        {
            return CharacterClass.Factory.Create("Guerreiro", Attributes.Factory.Create(15, 10, 10, 10, 10, 10), 12, Axe.Factory.Create());
        }

        private static CharacterClass CreateWizard()
        {
            return CharacterClass.Factory.Create("Mago", Attributes.Factory.Create(10, 10, 15, 10, 10, 10), 6, Staff.Factory.Create());
        }

        private static CharacterClass CreateRogue()
        {
            return CharacterClass.Factory.Create("Ladino", Attributes.Factory.Create(10, 15, 10, 10, 10, 10), 8, Dagger.Factory.Create());
        }

        private static CharacterClass CreateCleric()
        {
            return CharacterClass.Factory.Create("Clérigo", Attributes.Factory.Create(10, 10, 10, 15, 10, 10), 8, Staff.Factory.Create());
        }

        private static CharacterClass CreateBarbarian()
        {
            return CharacterClass.Factory.Create("Bárbaro", Attributes.Factory.Create(15, 10, 10, 10, 10, 10), 12, Axe.Factory.Create());
        }

        private static CharacterClass CreateDruid()
        {
            return CharacterClass.Factory.Create("Druida", Attributes.Factory.Create(10, 10, 10, 10, 15, 10), 8, Staff.Factory.Create());
        }

        private static CharacterClass CreateMonk()
        {
            return CharacterClass.Factory.Create("Monge", Attributes.Factory.Create(10, 10, 10, 10, 10, 15), 8, Staff.Factory.Create());
        }

        private static CharacterClass CreatePaladin()
        {
            return CharacterClass.Factory.Create("Paladino", Attributes.Factory.Create(10, 10, 10, 10, 10, 10), 10, Sword.Factory.Create());
        }

        private static CharacterClass CreateRanger()
        {
            return CharacterClass.Factory.Create("Patrulheiro", Attributes.Factory.Create(10, 10, 10, 10, 10, 10), 10, Staff.Factory.Create());
        }

    }
}
