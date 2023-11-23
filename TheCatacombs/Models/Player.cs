using System;
namespace TheCatacombs.Models
{
    public class Player
    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public Attributes Attributes { get; private set; }
        public IWeapon? Weapon { get; private set; }

        public Player(string name, int health, Attributes attributes)
        {
            Name = name;
            Health = health;
            Attributes = attributes;
        }
    }
}

