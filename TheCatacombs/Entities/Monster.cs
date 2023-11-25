namespace TheCatacombs.Entities
{
    public class Monster : Character
    {
        public string Race { get; private set; }
        public int Gold { get; private set; }
        public int Experience { get; private set; }

        public Monster(string name, int maxHealth, int defense, Attributes baseAttributes, IWeapon weapon, string race, int gold, int experience)
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
