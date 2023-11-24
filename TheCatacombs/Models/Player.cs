using System;

namespace TheCatacombs.Models
{
    public class Player : Character
    {
        public CharacterClass? PlayerClass { get; private set; }

        public Player(string name, int maxHealth, IWeapon weapon, CharacterClass playerClass)
            : base(name, maxHealth, weapon, playerClass)
        {
            PlayerClass = playerClass;
        }
    }
}
