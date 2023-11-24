// GameManager.cs
using TheCatacombs.Enums;
using TheCatacombs.Models;
using TheCatacombs.Models.Weapons;
using TheCatacombs.UI;

namespace TheCatacombs.Services
{
    public class GameManager
    {
        private static GameManager instance;
        private Player player;
        private CombatManager combatManager;
        private ExplorationManager explorationManager;
        private CharacterManager characterManager;
        private GameState currentState;

        public static GameManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameManager();
                }
                return instance;
            }
        }

        private GameManager()
        {
            currentState = GameState.MainMenu;
            characterManager = new CharacterManager(this);  // Mova a criação aqui
            explorationManager = new ExplorationManager(this);  // Mova a criação aqui
        }

        public void StartGame()
        {
            ConsoleUI.DisplayMessage("Bem-vindo ao The Catacombs!");
            currentState = GameState.Exploration;
            player = characterManager.CreateCharacter();
            explorationManager.StartExploration();
        }

        public void StartCombat(bool useRandomMonster = true)
        {
            currentState = GameState.Combat;
            combatManager = new CombatManager(this);
            combatManager.StartCombat(useRandomMonster);
        }

        public void EndCombat(bool playerWon)
        {
            currentState = GameState.Exploration;
            explorationManager.StartExploration();
        }

        public GameState GetCurrentState()
        {
            return currentState;
        }

        public Player GetPlayer()
        {
            return player;
        }

        public CharacterManager GetCharacterManager()
        {
            return characterManager;
        }

        public ExplorationManager GetExplorationManager()
        {
            return explorationManager;
        }
    }
}