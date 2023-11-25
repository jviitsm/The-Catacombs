namespace TheCatacombs.Entities
{
    public abstract class Monster : Character
    {
        public MonsterType Race { get; private set; }
        public int Gold { get; private set; }
        public int Experience { get; private set; }


        public Monster(string name, int maxHealth, int defense, Attributes baseAttributes, IWeapon weapon, MonsterType race, int gold, int experience)
            : base(name, maxHealth, weapon, null)
        {
            Race = race;
            Gold = gold;
            Experience = experience;
            Defense = defense;
            BaseAttributes = baseAttributes;
            Weapon = weapon;
        }
    }
}
