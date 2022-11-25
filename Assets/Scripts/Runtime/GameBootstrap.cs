using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AddressableAssets;
using UnityEngine.Assertions;

using Random = UnityEngine.Random;

namespace Dune
{
    /// <summary>
    /// This component is responsible for bootstrapping the game/battle scene. This process
    /// mainly consists on:
    ///     - Creating the player character and the associated UI widgets.
    ///     - Creating the enemy character/s and the associated UI widgets.
    ///     - Starting the turn sequence.
    /// </summary>
    public class GameBootstrap : MonoBehaviour
    {
#pragma warning disable 649
        [Header("Pools")]
        [SerializeField]
        private ObjectPool cardPool;
#pragma warning restore 649

        private Camera mainCamera;

        private List<CardTemplate> playerDeck = new List<CardTemplate>();

        private GameObject player;
        private List<GameObject> enemies = new List<GameObject>();

        // private GameInfo gameInfo;

        private void Start()
        {
            mainCamera = Camera.main;

            cardPool.Initialize();

            // CreatePlayer(characterTemplate);
        }

        // private void CreatePlayer(AssetReference templateRef)
        // {
        //     InitializeGame();
        // }

        private void InitializeGame()
        {

        }
    }
}
