using TheCatacombs.Entities;
using TheCatacombs.Entities.Monsters;
using TheCatacombs.Entities.Weapons;
using TheCatacombs.UI;

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
        return Attributes.Factory.Create(
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
        var monsterMaxHealth = GenerateRandomValueInRange(80, 200);
        var monsterDefense = GenerateRandomValueInRange(1, 5);
        var monsterGold = GenerateRandomValueInRange(1, 3);
        var monsterExperience = GenerateRandomValueInRange(1, 3);
        var monsterAttributes = GenerateRandomAttributes();

        IWeapon monsterWeapon = Axe.Factory.Create();

        var goblin = Goblin.Factory.Create("Monstrinho", monsterMaxHealth, monsterDefense, monsterAttributes, monsterWeapon, monsterGold, monsterExperience);

        return goblin;
    }

    public static void DisplayMonsterInfo(Monster monster)
    {
        monster.Draw();
        ConsoleUI.DisplayMessage($"Nome: {monster.Name}");
        ConsoleUI.DisplayMessage($"Raça: {monster.Race}");
        ConsoleUI.DisplayMessage($"Vida: {monster.CurrentHealth}/{monster.MaxHealth}");
        ConsoleUI.DisplayMessage($"Defesa: {monster.Defense}");
        ConsoleUI.DisplayMessage($"Atributos:");
        ConsoleUI.DisplayMessage($"  Força: {monster.BaseAttributes.Strength}");
        ConsoleUI.DisplayMessage($"  Destreza: {monster.BaseAttributes.Dexterity}");
        ConsoleUI.DisplayMessage($"  Inteligência: {monster.BaseAttributes.Intelligence}");
        ConsoleUI.DisplayMessage($"  Sabedoria: {monster.BaseAttributes.Wisdom}");
        ConsoleUI.DisplayMessage($"  Constituição: {monster.BaseAttributes.Constitution}");
        ConsoleUI.DisplayMessage($"  Carisma: {monster.BaseAttributes.Charisma}");
        ConsoleUI.DisplayMessage($"Ouro: {monster.Gold}");
        ConsoleUI.DisplayMessage($"Experiência: {monster.Experience}");
        ConsoleUI.DisplayMessage($"Arma: {monster.Weapon?.Name ?? "Nenhuma"}");
    }
}
