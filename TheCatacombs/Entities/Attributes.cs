namespace TheCatacombs.Entities
{
    public class Attributes
    {
        public int Strength { get; private set; }
        public int Dexterity { get; private set; }
        public int Constitution { get; private set; }
        public int Intelligence { get; private set; }
        public int Wisdom { get; private set; }
        public int Charisma { get; private set; }

        public static class Factory
        {
            public static Attributes Create(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
            {
                return new Attributes(strength, dexterity, constitution, intelligence, wisdom, charisma);
            }

            public static Attributes Create()
            {
                return new Attributes(0, 0, 0, 0, 0, 0);
            }
        }

        private Attributes(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
        {
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intelligence = intelligence;
            Wisdom = wisdom;
            Charisma = charisma;
        }

        public void IncreaseStrength(int amount) => Strength += amount;
        public void IncreaseDexterity(int amount) => Dexterity += amount;
        public void IncreaseConstitution(int amount) => Constitution += amount;
        public void IncreaseIntelligence(int amount) => Intelligence += amount;
        public void IncreaseWisdom(int amount) => Wisdom += amount;
        public void IncreaseCharisma(int amount) => Charisma += amount;

    }
}