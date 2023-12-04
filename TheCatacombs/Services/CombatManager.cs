using TheCatacombs.Entities;
using TheCatacombs.UI;


namespace TheCatacombs.Services
{
    public class CombatManager
    {
        private GameManager gameManager;
        private static Random random = new Random();
        private Player player;


        public CombatManager(GameManager gameManager)
        {
            this.gameManager = GameManager.Instance;
            this.player = gameManager.GetPlayer();
        }

        public void StartCombat(bool useRandomMonster = true)
        {
            Monster monster;

            if (useRandomMonster)
                monster = MonsterManager.GenerateRandomMonster();
            else
                monster = player.CurrentRoom.MonstersPositions.Find(monster => monster.ID == player.CurrentRoom.LastMonsterID).Monster;

            PerformCombat(monster);
        }

        private void PerformCombat(Monster monster)
        {
            ConsoleUI.DisplayMessage($"Você encontrou um {monster.Name}!");

            ConsoleUI.DisplayMessage("-------------------------------------");
            MonsterManager.DisplayMonsterInfo(monster);

            while (player.CurrentHealth > 0 && monster.CurrentHealth > 0)
            {
                PerformCombatRound(monster);
            }

            EndCombat(player.CurrentHealth > 0, monster);
        }

        private void PerformCombatRound(Monster monster)
        {
            ConsoleUI.DisplayMessage("Sua vez de agir!");
            ConsoleUI.DisplayMessage("Escolha uma ação:");
            ConsoleUI.DisplayMessage("1 - Atacar");
            ConsoleUI.DisplayMessage($"2 - Examinar o {monster.Name}");

            string input = ConsoleUI.GetUserInput();

            switch (input)
            {
                case "1":
                    PerformPlayerAttack(monster);
                    PerformMonsterAttack(monster);
                    break;
                case "2":
                    MonsterManager.DisplayMonsterInfo(monster);
                    PerformCombatRound(monster);
                    break;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    break;
            }
        }

        private void PerformPlayerAttack(Monster monster)
        {
            int playerDamage = CalculateDamage(player.BaseAttributes.Strength + 50, player.BaseAttributes.Dexterity, player.AttackBonus, monster.Defense, player.Weapon?.Damage ?? 0);
            monster.TakeDamage(playerDamage);
            ConsoleUI.DisplayMessage($"Você atacou o {monster.Name} e causou {playerDamage} de dano.");
        }

        private void PerformMonsterAttack(Monster monster)
        {
            int monsterDamage = CalculateDamage(monster.BaseAttributes.Strength, monster.BaseAttributes.Dexterity,
             monster.AttackBonus, player.Defense, monster.Weapon.Damage);
            player.TakeDamage(monsterDamage);
            ConsoleUI.DisplayMessage($"{monster.Name} atacou você e causou {monsterDamage} de dano.");

            if (player.CurrentHealth <= 0)
            {
                ConsoleUI.DisplayMessage("Você foi derrotado!");
            }
        }

        private static int CalculateDamage(int attackerStrength, int attackerDexterity, int attackerAttackBonus, int defenderDefense, int weaponDamage)
        {
            int attackRoll = RollD20() + attackerAttackBonus;

            if (attackRoll >= defenderDefense)
            {
                bool isCritical = attackRoll == 20; // Verifica se é um acerto crítico
                int damageRoll = RollDamage(attackerStrength, attackerDexterity, weaponDamage, isCritical);
                return damageRoll;
            }

            ConsoleUI.DisplayMessage("O ataque falhou!");
            return 0;
        }


        private static int RollDamage(int attackerStrength, int attackerDexterity, int weaponDamage, bool isCritical)
        {
            int strengthModifier = (attackerStrength - 10) / 2;
            int dexterityModifier = (attackerDexterity - 10) / 2;
            int weaponRoll = isCritical ? 2 * random.Next(1, 7) : random.Next(1, 7);

            return weaponDamage + strengthModifier + dexterityModifier + weaponRoll;
        }

        private static int RollD20()
        {
            return random.Next(1, 21);
        }

        private void EndCombat(bool playerWon, Monster monster)
        {
            if (!playerWon)
            {
                ConsoleUI.DisplayMessage("Que pena! Você morreu!");
            }
            else
            {
                ConsoleUI.DisplayMessage("Você venceu a batalha!");
                ConsoleUI.DisplayMessage($"Você ganhou {monster.Gold} moedas de ouro!");
                ConsoleUI.DisplayMessage($"Você ganhou {monster.Experience} pontos de experiência!");

                ContinueAfterVictory();
            }
        }

        private void ContinueAfterVictory()
        {
            player.CurrentRoom.MonstersPositions.Find(monster => monster.ID == player.CurrentRoom.LastMonsterID).SetDefeated();
            gameManager.GetExplorationManager().StartExploration();
        }
    }
}
