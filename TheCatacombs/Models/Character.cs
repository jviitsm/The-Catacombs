
namespace TheCatacombs.Models
{
    public class Character
    {
        public string Name { get; private set; }
        public int MaxHealth { get; private set; }
        public int CurrentHealth { get; private set; }
        public int AttackBonus { get; private set; }
        public int Defense { get; private set; }

        public Character(string name, int maxHealth)
        {
            Name = name;
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(int damage)
        {
            CurrentHealth -= damage;
        }
    }
}