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
        public int X { get; set; } = 1; // Coordenada X da sala no mapa
        public int Y { get; set; } = 1; // Coordenada Y da sala no mapa

        private static Random random = new Random();

        public Room(string description, MonsterType? monsterType = null)
        {
            Description = description;
            MonsterType = monsterType ?? GetRandomMonsterType();
            IsLocked = false;
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
        }
    }
}
