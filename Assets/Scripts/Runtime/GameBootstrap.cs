using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AddressableAssets;
using UnityEngine.Assertions;

using Random = UnityEngine.Random;

namespace Dune
{
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
