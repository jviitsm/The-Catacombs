using TheCatacombs.Entities;
namespace TheCatacombs.Entities
{
    public class CharacterClass
    {
        public string ClassName { get; set; }
        public Attributes BaseAttributes { get; set; }
        public IWeapon PreferredWeapon { get; set; }
        public int BaseHitDie { get; set; }

        public class Factory
        {
            public static CharacterClass Create(string className, Attributes baseAttributes, int baseHitDie, IWeapon preferredWeapon)
            {
                return new CharacterClass(className, baseAttributes, baseHitDie, preferredWeapon);
            }
        }

        private CharacterClass(string className, Attributes baseAttributes, int baseHitDie, IWeapon preferredWeapon)
        {
            ClassName = className;
            BaseAttributes = baseAttributes;
            PreferredWeapon = preferredWeapon;
            BaseHitDie = baseHitDie;
        }
    }
}
