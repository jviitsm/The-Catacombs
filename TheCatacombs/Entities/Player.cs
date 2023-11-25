using System;
using TheCatacombs.Enums;

namespace TheCatacombs.Entities
{
    public class Player : Character
    {
        public CharacterClass? PlayerClass { get; private set; }
        public Room CurrentRoom { get; set; }

        public Player(string name, int maxHealth, IWeapon weapon, CharacterClass playerClass, Room startingRoom)
            : base(name, maxHealth, weapon, playerClass)
        {
            PlayerClass = playerClass;
            CurrentRoom = new Room(startingRoom.Description, startingRoom.MonsterType);

        }

        public void SetCurrentRoom(Room room)
        {
            CurrentRoom = room;
        }

        public override void Draw()
        {
            Console.Write("P");
        }
    }
}
