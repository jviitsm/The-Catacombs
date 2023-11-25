using TheCatacombs.Entities.Weapons;

namespace TheCatacombs.Entities
{
    public class Character
    {
        public string Name { get; private set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }
        public int AttackBonus { get; private set; }
        public int Defense { get; set; }
        public IWeapon? Weapon { get; set; }
        public CharacterClass? Class { get; set; }
        public Attributes BaseAttributes { get; set; }

        public Character(string name, int maxHealth, IWeapon weapon, CharacterClass? characterClass)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Class = characterClass;
            Weapon = weapon;
            BaseAttributes = Class?.BaseAttributes ?? new Attributes();

        }


        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
        }
    }
}
