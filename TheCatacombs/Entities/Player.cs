using System;
using TheCatacombs.Enums;

namespace TheCatacombs.Entities
{
    public class Player : Character
    {
        public CharacterClass? PlayerClass { get; private set; }
        public Room CurrentRoom { get; set; }
        public override int MaxHealth => CalculateMaxHealth();
        public override int CurrentHealth { get; protected set; }


        public static class Factory
        {
            public static Player Create(string name, IWeapon weapon, CharacterClass playerClass, Room startingRoom)
            {
                return new Player(name, weapon, playerClass, startingRoom);
            }
        }

        public void SetCurrentRoom(Room room)
        {
            CurrentRoom = room;
        }

        public override void Draw()
        {
            Console.Write("P");
        }

        public int CalculateMaxHealth()
        {
            if (Class == null || Class.BaseAttributes == null)
            {
                throw new InvalidOperationException("PlayerClass or BaseAttributes cannot be null.");
            }

            int constitutionModifier = Class.BaseAttributes.ConstitutionModifier;
            int hitDie = Class.BaseHitDie;

            int numberOfHitDice = Level;

            int maxHealth = constitutionModifier + hitDie + (constitutionModifier * numberOfHitDice);

            return maxHealth;
        }


        private Player(string name, IWeapon weapon, CharacterClass playerClass, Room startingRoom)
            : base(name, weapon, playerClass)
        {
            CurrentHealth = MaxHealth;
            PlayerClass = playerClass;
            CurrentRoom = startingRoom;
        }

    }
}
