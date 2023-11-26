namespace TheCatacombs.Entities
{
    public class MonstersRoomInfo
    {
        public string ID { get; }
        public int X { get; }
        public int Y { get; }
        public int Level { get; }
        public bool IsDefeated { get; private set; } = false;
        public Monster? Monster { get; private set; } = null;

        public static class Factory
        {
            public static MonstersRoomInfo Create(int x, int y, int level)
            {
                return new MonstersRoomInfo(x, y, level);
            }
        }

        public void SetMonster(Monster monster)
        {
            Monster = monster;
        }


        public void SetDefeated()
        {
            IsDefeated = true;
        }

        private MonstersRoomInfo(int x, int y, int level)
        {
            ID = Guid.NewGuid().ToString();
            X = x;
            Y = y;
            Level = level;
        }

    }
}