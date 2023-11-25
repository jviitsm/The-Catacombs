// GameManager.cs
using TheCatacombs.Enums;
using TheCatacombs.Entities;
using TheCatacombs.Entities.Weapons;
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
        private MovementManager movementManager;

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
            characterManager = new CharacterManager(this);
            explorationManager = new ExplorationManager(this);
        }

        public void StartGame()
        {
            ConsoleUI.DisplayMessage("Bem-vindo ao The Catacombs!");
            currentState = GameState.Exploration;
            player = characterManager.CreateCharacter();

            movementManager = new MovementManager(this);

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

        public MovementManager GetMovementManager()
        {
            return movementManager;
        }
    }
}
