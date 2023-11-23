using System;
namespace TheCatacombs.Models
{
    public class Player : Character
    {
        public Attributes Attributes { get; private set; }
        public IWeapon? Weapon { get; private set; }

        public Player(string name, int maxHealth, Attributes attributes, IWeapon? weapon) : base(name, maxHealth)
        {
            Attributes = attributes;
            Weapon = weapon;
        }
    }
}

