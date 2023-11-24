using TheCatacombs.Models;
namespace TheCatacombs.Models
{
    public class CharacterClass
    {
        public string ClassName { get; set; }
        public Attributes BaseAttributes { get; set; }
        public IWeapon PreferredWeapon { get; set; }

        public CharacterClass(string className, Attributes baseAttributes, IWeapon preferredWeapon)
        {
            ClassName = className;
            BaseAttributes = baseAttributes;
            PreferredWeapon = preferredWeapon;
        }
    }
}
