using System;
using TheCatacombs.Enums;
using TheCatacombs.UI;

namespace TheCatacombs.Entities
{
    public class Room
    {
        public string Description { get; set; }
        public MonsterType MonsterType { get; set; }
        public bool IsBossRoom { get; set; } = false;
        public bool IsLocked { get; set; }
        public bool IsCleared { get; set; } = false;
        public int Height { get; set; } = 10; // Altura padrão
        public int Width { get; set; } = 10; // Largura padrão
        public int X { get; set; } = 0; // Coordenada X da sala no mapa
        public int Y { get; set; } = 0; // Coordenada Y da sala no mapa
        public List<Tuple<int, int>> VisitedPositions { get; set; } = new List<Tuple<int, int>>();


        private static Random random = new Random();

        public Room(string description, MonsterType? monsterType = null)
        {
            Description = description;
            MonsterType = monsterType ?? GetRandomMonsterType();
            IsLocked = false;
            VisitedPositions.Add(new Tuple<int, int>(X, Y));
        }

        private static MonsterType GetRandomMonsterType()
        {
            Array monsterTypes = Enum.GetValues(typeof(MonsterType));
            return (MonsterType)monsterTypes.GetValue(random.Next(monsterTypes.Length));
        }

        public void SetNewPosition(int x, int y)
        {
            X = x;
            Y = y;
            VisitedPositions.Add(new Tuple<int, int>(X, Y));
        }

        public void DrawRoom()
        {
            Console.WriteLine(new string('\n', 50));

            ConsoleUI.DisplayMessage($"POSICOES{X}, {Y}");
            for (int i = Height - 1; i >= 0; i--)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == Y && j == X)
                    {
                        Console.Write("P"); // Desenha o jogador
                    }
                    else
                    {
                        if (VisitedPositions.Contains(new Tuple<int, int>(j, i)))
                            Console.Write("."); // Desenha uma parte visitada da sala
                        else
                            Console.Write("?"); // Desenha uma parte vazia da sala
                    }
                }
                Console.WriteLine(); // Muda para a próxima linha após desenhar uma linha completa
            }

            Console.WriteLine($"Você está na sala: {Description}");
        }

    }
}
