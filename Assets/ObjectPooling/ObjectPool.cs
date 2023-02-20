using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ObjectPool : MonoSingleton<ObjectPool>
{
    [Serializable]
    public struct Pool
    {
        public Queue<GameObject> pooledObjects;
        public GameObject prefab;
        public int poolSize;
    }

    [SerializeField] Pool[] pools;

    private void Awake()
    {
        for (int j = 0; j < pools.Length; j++)
        {
            pools[j].pooledObjects = new Queue<GameObject>();

            for (int i = 0; i < pools[j].poolSize; i++)
            {
                GameObject obj = Instantiate(pools[j].prefab); // create object
                obj.SetActive(false); // close object
                obj.transform.SetParent(transform);
                pools[j].pooledObjects.Enqueue(obj); // add to list
            }
        }
    }

    public GameObject GetPooledObject(int objectType)
    {
        if (objectType > pools.Length)
            return null; // null check


        GameObject obj = pools[objectType].pooledObjects.Dequeue(); // get from list
        obj.SetActive(true); // set active

        pools[objectType].pooledObjects.Enqueue(obj); // add to queue

        return obj;
    }

    public void SetBooledObject(GameObject obj)
    {
        obj.SetActive(false);
        obj.transform.SetParent(transform);
    }
}
