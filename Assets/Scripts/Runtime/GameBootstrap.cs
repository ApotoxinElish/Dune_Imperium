using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AddressableAssets;
using UnityEngine.Assertions;

using Random = UnityEngine.Random;

public class GameBootstrap : MonoBehaviour
{
#pragma warning disable 649
    [Header("Pools")]
    [SerializeField]
    private ObjectPool cardPool;
#pragma warning restore 649

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;

        cardPool.Initialize();
    }
}
