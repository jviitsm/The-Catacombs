using System;
using TheCatacombs.Entities.Monsters;
using TheCatacombs.Enums;
using TheCatacombs.UI;

namespace TheCatacombs.Entities
{
    public class Room
    {
        public string Description { get; private set; }
        public MonsterType MonsterType { get; private set; }
        public int Level { get; private set; } = 1;
        public bool IsBossRoom => CheckIsBossLevel();
        public bool IsLocked { get; private set; }
        public bool IsCleared { get; private set; } = false;
        public int Height { get; private set; } = 10; // Altura padrão
        public int Width { get; private set; } = 10; // Largura padrão
        public int X { get; private set; } = 0; // Coordenada X da sala no mapa
        public int Y { get; private set; } = 0; // Coordenada Y da sala no mapa
        public List<Tuple<int, int>> VisitedPositions { get; private set; } = new List<Tuple<int, int>>();
        public List<MonstersRoomInfo> MonstersPositions;
        public string LastMonsterID { get; private set; }

        private static Random random = new Random();

        private Room(string description, MonsterType? monsterType = null)
        {
            Description = description;
            MonsterType = monsterType ?? GetRandomMonsterType();
            Level++;
            IsLocked = false;
            VisitedPositions.Add(new Tuple<int, int>(X, Y));
            MonstersPositions = GenerateMonsters();
        }

        public static class Factory
        {
            public static Room Create(string description, MonsterType? monsterType = null)
            {
                return new Room(description, monsterType);
            }
        }

        public void SetNewPosition(int x, int y)
        {
            X = x;
            Y = y;
            VisitedPositions.Add(new Tuple<int, int>(X, Y));
        }

        public void setLastMonsterID(string id)
        {
            LastMonsterID = id;
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
                        Console.Write("P"); // Draw the player
                    }
                    else if (VisitedPositions.Contains(new Tuple<int, int>(j, i)))
                    {
                        Console.Write("."); // Draw a visited part of the room
                    }
                    else if (HasMonsterAtPosition(j, i))
                    {
                        Console.Write("M"); // Draw a monster
                    }
                    else
                    {
                        Console.Write("?"); // Draw an empty part of the room
                    }
                }
                Console.WriteLine(); // Muda para a próxima linha após desenhar uma linha completa
            }
            Console.WriteLine($"Você está na sala: {Description}");
        }

        private List<MonstersRoomInfo> GenerateMonsters()
        {
            List<MonstersRoomInfo> monsters = new List<MonstersRoomInfo>();

            int numberOfMonsters = random.Next(1, 4);

            for (int i = 0; i < numberOfMonsters; i++)
            {
                int monsterX, monsterY;

                do
                {
                    monsterX = random.Next(0, Width);
                    monsterY = random.Next(0, Height);
                } while (monsterX == 0 && monsterY == 0);

                int monsterLevel = random.Next(1, 4);

                monsters.Add(MonstersRoomInfo.Factory.Create(monsterX, monsterY, monsterLevel));
            }

            return monsters;
        }

        private bool CheckIsBossLevel()
        {
            return Level % 5 == 0;
        }

        private bool HasMonsterAtPosition(int x, int y)
        {
            return MonstersPositions.Any(monster => monster.X == x && monster.Y == y);
        }

        private static MonsterType GetRandomMonsterType()
        {
            Array monsterTypes = Enum.GetValues(typeof(MonsterType));
            return (MonsterType)monsterTypes.GetValue(random.Next(monsterTypes.Length));
        }



    }
}
