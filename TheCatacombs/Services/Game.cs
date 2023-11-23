using TheCatacombs.Models;
using TheCatacombs.Models.Weapons;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class Game
    {
        private Player player;
        private CombatManager combatManager;
        private ExplorationManager explorationManager;
        private CharacterManager characterManager;


        public Game()
        {
            combatManager = new CombatManager();
            explorationManager = new ExplorationManager();
            characterManager = new CharacterManager();
        }



        public void Start()
        {
            ConsoleUI.DisplayMessage("Bem-vindo ao The Catacombs!");

            player = characterManager.CreateCharacter();

            explorationManager.StartExploration(player);
        }
    }
}