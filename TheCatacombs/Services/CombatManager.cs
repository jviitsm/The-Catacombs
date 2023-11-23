using TheCatacombs.Models;
using TheCatacombs.Models.Weapons;
using TheCatacombs.UI;
using System;

namespace TheCatacombs.Services
{
    public class CombatManager
    {
        private static Random random = new Random();

        public void StartCombat(Player player)
        {
            Monster monster = MonsterManager.GenerateRandomMonster();
            ConsoleUI.DisplayMessage($"Você encontrou um {monster.Name}!");

            while (player.CurrentHealth > 0 && monster.CurrentHealth > 0)
            {
                PerformCombatRound(player, monster);
            }

            EndCombat(player.CurrentHealth > 0);
        }



        private void PerformCombatRound(Player player, Monster monster)
        {
            ConsoleUI.DisplayMessage("Sua vez de agir!");
            ConsoleUI.DisplayMessage("Escolha uma ação:");
            ConsoleUI.DisplayMessage("1 - Atacar");

            string input = ConsoleUI.GetUserInput();

            switch (input)
            {
                case "1":
                    PerformPlayerAttack(player, monster);
                    PerformMonsterAttack(player, monster);
                    break;
                default:
                    ConsoleUI.DisplayMessage("Opção inválida!");
                    break;
            }
        }

        private static void PerformPlayerAttack(Player player, Monster monster)
        {
            int playerDamage = CalculateDamage(player.Attributes.Strength, player.Attributes.Dexterity, player.AttackBonus, monster.Defense, player.Weapon?.Damage ?? 0);
            monster.TakeDamage(playerDamage);
            ConsoleUI.DisplayMessage($"Você atacou o {monster.Name} e causou {playerDamage} de dano.");
        }

        private static void PerformMonsterAttack(Player player, Monster monster)
        {
            int monsterDamage = CalculateDamage(monster.Attributes.Strength, monster.Attributes.Dexterity, monster.AttackBonus, player.Defense, monster.Weapon.Damage);
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
                int damageRoll = RollDamage(attackerStrength, attackerDexterity, weaponDamage);
                return damageRoll;
            }

            ConsoleUI.DisplayMessage("O ataque falhou!");
            return 0;
        }

        private static int RollD20()
        {
            return random.Next(1, 21);
        }

        private static int RollDamage(int attackerStrength, int attackerDexterity, int weaponDamage)
        {
            int strengthModifier = (attackerStrength - 10) / 2;
            int dexterityModifier = (attackerDexterity - 10) / 2;
            int weaponRoll = random.Next(1, 7);

            return weaponDamage + strengthModifier + dexterityModifier + weaponRoll;
        }

        private static void EndCombat(bool playerWon)
        {
            if (!playerWon)
            {
                ConsoleUI.DisplayMessage("Que pena! Você morreu!");
            }
            else
            {
                ConsoleUI.DisplayMessage("Você venceu a batalha!");
                ConsoleUI.DisplayMessage("Você ganhou 100 pontos de experiência!");
            }
        }
    }
}
