namespace TheCatacombs.Models
{
    public class Monster : Character
    {

        public Attributes Attributes { get; private set; }
        public int Defense { get; private set; }
        public int Gold { get; private set; }
        public int Experience { get; private set; }
        public IWeapon Weapon { get; private set; }

        public Monster(string name, int maxHealth, int defense, int gold, int experience, Attributes attributes, IWeapon weapon) : base(name, maxHealth)
        {
            Defense = defense;
            Gold = gold;
            Experience = experience;
            Attributes = attributes;
            Weapon = weapon;
        }
    }
}