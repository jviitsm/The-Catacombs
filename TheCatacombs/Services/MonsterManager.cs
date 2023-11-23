using TheCatacombs.Models;
using TheCatacombs.Models.Weapons;

public static class MonsterManager
{
    private static Random random = new Random();
    private const int MinAttributeValue = 1;
    private const int MaxAttributeValue = 3;

    private static int GenerateRandomAttributeValue() => random.Next(MinAttributeValue, MaxAttributeValue + 1);

    private static int GenerateRandomValueInRange(int minValue, int maxValue) => random.Next(minValue, maxValue + 1);

    private static int GenerateRandomValue(int minValue, int maxValue) => random.Next(minValue, maxValue + 1);

    private static Attributes GenerateRandomAttributes()
    {
        return new Attributes(
            GenerateRandomAttributeValue(),
            GenerateRandomAttributeValue(),
            GenerateRandomAttributeValue(),
            GenerateRandomAttributeValue(),
            GenerateRandomAttributeValue(),
            GenerateRandomAttributeValue()
        );
    }

    public static Monster GenerateRandomMonster()
    {
        var monsterName = "Goblin";

        var monsterMaxHealth = GenerateRandomValueInRange(80, 200);
        var monsterDefense = GenerateRandomValueInRange(1, 5);
        var monsterGold = GenerateRandomValueInRange(1, 3);
        var monsterExperience = GenerateRandomValueInRange(1, 3);
        var monsterWeapon = new Axe();
        var monsterAttributes = GenerateRandomAttributes();

        return new Monster(monsterName, monsterMaxHealth, monsterDefense, monsterGold, monsterExperience, monsterAttributes, monsterWeapon);
    }
}
