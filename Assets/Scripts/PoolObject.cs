using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolObject : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject objectToPool;
    public int numToPool;

    public List<GameObject> pooledList;
    public static PoolObject SharedInstance;

    private void Awake()
    {
        SharedInstance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        pooledList = new List<GameObject>();
        GameObject tmp;
        for(int i = 0; i< numToPool; i++)
        {
            tmp = Instantiate(objectToPool);
            tmp.SetActive(false);
            pooledList.Add(tmp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetPooledObject()
    {
        for(int i = 0; i < numToPool; i++)
        {
            if(!pooledList[i].activeInHierarchy)
            {
                return pooledList[i];
            }
        }
        return null;
    }

    public int GetPoolNum()
    {
        return numToPool;
    }
}
