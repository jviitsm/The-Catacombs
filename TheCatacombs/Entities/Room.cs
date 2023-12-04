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
        public Tuple<int, int> DoorPosition { get; private set; }
        public List<Tuple<int, int>> VisitedPositions { get; private set; } = new List<Tuple<int, int>>();
        public List<MonstersRoomInfo> MonstersPositions;
        public string LastMonsterID { get; private set; }

        private static Random random = new Random();

        private Room(string description)
        {
            Description = description;
            Level++;
            IsLocked = false;
            VisitedPositions.Add(new Tuple<int, int>(X, Y));
            DoorPosition = GenerateDoorPosition();
            MonstersPositions = GenerateMonsters();
        }

        public static class Factory
        {
            public static Room Create(string description, MonsterType? monsterType = null)
            {
                return new Room(description);
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
            //Console.WriteLine(new string('\n', 50));

            for (int i = Height - 1; i >= 0; i--)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (i == Y && j == X)
                    {
                        Console.Write("P"); // Draw the player
                    }
                    else if (j == DoorPosition.Item1 && DoorPosition.Item2 == i)
                    {
                        Console.Write("D"); // Draw the door
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

        private Tuple<int, int> GenerateDoorPosition()
        {
            int doorX = random.Next(0, Width);
            int doorY = Height - 1;

            return new Tuple<int, int>(doorX, doorY);
        }

        private List<MonstersRoomInfo> GenerateMonsters()
        {
            List<MonstersRoomInfo> monsters = new List<MonstersRoomInfo>();
            HashSet<Tuple<int, int>> occupiedPositions = new HashSet<Tuple<int, int>>();

            int numberOfMonsters = random.Next(1, 4);

            for (int i = 0; i < numberOfMonsters; i++)
            {
                int monsterX, monsterY;

                do
                {
                    monsterX = random.Next(0, Width);
                    monsterY = random.Next(0, Height);
                } while (monsterX == 0 && monsterY == 0 || (monsterX == DoorPosition.Item1 && monsterY == DoorPosition.Item2)
                 || occupiedPositions.Contains(new Tuple<int, int>(monsterX, monsterY)));

                int monsterLevel = random.Next(1, 4);

                var monster = MonsterManager.GenerateRandomMonster();

                monsters.Add(MonstersRoomInfo.Factory.Create(monsterX, monsterY, monsterLevel, monster));
                occupiedPositions.Add(new Tuple<int, int>(monsterX, monsterY));
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
