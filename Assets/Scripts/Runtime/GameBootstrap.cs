using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.AddressableAssets;
using UnityEngine.Assertions;

using Random = UnityEngine.Random;

public class GameBootstrap : MonoBehaviour
{
    [Header("Pools")]
    [SerializeField]
    private ObjectPool cardPool;

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;

        cardPool.Initialize();
    }
}
