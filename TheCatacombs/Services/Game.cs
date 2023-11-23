using TheCatacombs.Models;
using TheCatacombs.Models.Weapons;

namespace TheCatacombs.Services
{
    public class Game
    {
        private Player player;
        private IWeapon weapon;
        private Attributes playerAttributes;

        public Game()
        {
        }

        public void Start()
        {
            Console.WriteLine("Bem-vindo ao The Catacombs!");

            var name = ChooseName();
            ChooseClass();
            player = new Player(name, 100, playerAttributes);

            Console.WriteLine($"Bem-vindo, {player.Name}!");
            Console.WriteLine("Aqui estão seus atributos iniciais:");
            DisplayCharacterInfo(player);
        }

        private void DisplayCharacterInfo(Player player)
        {
            Console.WriteLine($"Nome: {player.Name}");
            Console.WriteLine($"Vida: {player.Health}");
            Console.WriteLine($"Força: {player.Attributes.Strength}");
            Console.WriteLine($"Destreza: {player.Attributes.Dexterity}");
            Console.WriteLine($"Inteligência: {player.Attributes.Intelligence}");
            Console.WriteLine($"Sabedoria: {player.Attributes.Wisdom}");
            Console.WriteLine($"Constituição: {player.Attributes.Constitution}");
            Console.WriteLine($"Carisma: {player.Attributes.Charisma}");
            Console.WriteLine($"Arma: {player.Weapon?.Name ?? "Nenhuma"}");
        }

        private string ChooseName()
        {
            Console.WriteLine("Escolha um nome para o seu personagem:");
            string name = Console.ReadLine();
            return name;
        }

        private void ChooseClass()
        {
            Console.WriteLine("Escolha uma classe:");
            Console.WriteLine("1 - Guerreiro");
            Console.WriteLine("2 - Mago");
            Console.WriteLine("3 - Ladino");
            Console.WriteLine("4 - Clérigo");
            Console.WriteLine("5 - Bárbaro");
            Console.WriteLine("6 - Druida");
            Console.WriteLine("7 - Monge");
            Console.WriteLine("8 - Paladino");
            Console.WriteLine("9 - Patrulheiro");
            Console.WriteLine("0 - Sair");

            string input = Console.ReadLine();

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
                    break;
                case "4":
                    playerAttributes = new Attributes(10, 10, 10, 15, 10, 10);
                    break;
                case "5":
                    playerAttributes = new Attributes(15, 10, 10, 10, 10, 10);
                    break;
                case "6":
                    playerAttributes = new Attributes(10, 10, 10, 10, 15, 10);
                    break;
                case "7":
                    playerAttributes = new Attributes(10, 10, 10, 10, 10, 15);
                    break;
                case "8":
                    playerAttributes = new Attributes(10, 10, 10, 10, 10, 10);
                    break;
                case "9":
                    playerAttributes = new Attributes(10, 10, 10, 10, 10, 10);
                    break;
                case "0":
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    ChooseClass();
                    break;
            }
        }

    }
}