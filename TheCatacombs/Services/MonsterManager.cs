using TheCatacombs.Entities;
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
        var monsterRace = "Orc"; // Substitua isso pela lógica para gerar uma raça aleatória para o monstro
        var monsterAttributes = GenerateRandomAttributes();

        // Substitua isso pela lógica para gerar uma arma aleatória para o monstro
        // A lógica pode ser semelhante à lógica usada para gerar a arma do jogador
        IWeapon monsterWeapon = new Axe();

        // Crie uma instância de Monster usando o construtor que aceita a arma e, em seguida, ajuste as outras propriedades
        var monster = new Monster(monsterName, monsterMaxHealth, monsterDefense, monsterAttributes, monsterWeapon, monsterRace, monsterGold, monsterExperience);

        return monster;
    }

    public static Monster GetSpecificMonster()
    {
        var monsterName = "Bruxa";
        var monsterMaxHealth = 300;
        var monsterDefense = 10;
        var monsterGold = 100;
        var monsterExperience = 100;
        var monsterRace = "Bruxa";
        var monsterAttributes = new Attributes(12, 13, 10, 10, 10, 10);

        IWeapon monsterWeapon = new Staff();

        var monster = new Monster(monsterName, monsterMaxHealth, monsterDefense, monsterAttributes, monsterWeapon, monsterRace, monsterGold, monsterExperience);

        return monster;

    }

    public static void DisplayMonsterInfo(Monster monster)
    {
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
