using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class ObjectPool : MonoBehaviour
{
    public GameObject Prefab;
    public int InitialSize;

    private readonly Stack<GameObject> instances = new Stack<GameObject>();
    private readonly List<GameObject> objectsToReturn = new List<GameObject>();

    private readonly List<PooledObject> childrenComponents = new List<PooledObject>(32);

    private void Awake()
    {
        Assert.IsNotNull(Prefab);
    }

    public void Initialize()
    {
        for (var i = 0; i < InitialSize; i++)
        {
            var obj = CreateInstance();
            obj.SetActive(false);
            instances.Push(obj);
        }
    }

    public GameObject GetObject()
    {
        var obj = instances.Count > 0 ? instances.Pop() : CreateInstance();
        obj.SetActive(true);
        return obj;
    }

    public void ReturnObject(GameObject obj)
    {
        var pooledObject = obj.GetComponent<PooledObject>();
        Assert.IsNotNull(pooledObject);
        Assert.IsTrue(pooledObject.Pool == this);

        obj.SetActive(false);
        if (!instances.Contains(obj))
        {
            instances.Push(obj);
        }
    }

    public void Reset()
    {
        objectsToReturn.Clear();

        transform.GetComponentsInChildren(false, childrenComponents);
        foreach (var obj in childrenComponents)
        {
            objectsToReturn.Add(obj.gameObject);
        }

        foreach (var instance in objectsToReturn)
        {
            ReturnObject(instance);
        }
    }

    private GameObject CreateInstance()
    {
        var obj = Instantiate(Prefab, transform, true);
        var pooledObject = obj.AddComponent<PooledObject>();
        pooledObject.Pool = this;
        return obj;
    }
}

public class PooledObject : MonoBehaviour
{
    public ObjectPool Pool;
}
