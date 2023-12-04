using TheCatacombs.Entities.Weapons;

namespace TheCatacombs.Entities
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public virtual int MaxHealth { get; protected set; }
        public virtual int CurrentHealth { get; protected set; }
        public int AttackBonus { get; protected set; }
        public int Defense { get; set; }
        public IWeapon? Weapon { get; set; }
        public CharacterClass? Class { get; set; }
        public Attributes BaseAttributes { get; set; }
        public int Level { get; protected set; }

        public Character(string name, int maxHealth, IWeapon weapon, CharacterClass? characterClass)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Class = characterClass;
            Weapon = weapon;
            BaseAttributes = Class?.BaseAttributes ?? Attributes.Factory.Create();
            Level = 1;
        }

        public Character(string name, IWeapon weapon, CharacterClass? characterClass)
        {
            Name = name;
            Class = characterClass;
            Weapon = weapon;
            BaseAttributes = Class?.BaseAttributes ?? Attributes.Factory.Create();
            Level = 1;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
        }

        public abstract void Draw();
    }
}
