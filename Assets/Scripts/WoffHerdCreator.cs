using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoffHerdCreator : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        //GameObject woff = PoolObject.SharedInstance.GetPooledObject();
        //Vector3 woffStart = new Vector3(72, 0.11f, Random.Range(-6f, 0f));

        //if (woff != null)
        //{
        //    woff.transform.position = woffStart; //Make woff positioni random within some space

        //    woff.SetActive(true);
        //}

        int poolNum = PoolObject.SharedInstance.GetPoolNum();

        for(int i = 0; i < poolNum; i++)
        {
            GameObject woff = PoolObject.SharedInstance.GetPooledObject();
            Vector3 woffStart = new Vector3(72, 0.11f, Random.Range(-6f, 0f));

            if(woff != null)
            {
                woff.transform.position = woffStart;
                woff.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject woff = PoolObject.SharedInstance.GetPooledObject();
        Vector3 woffStart = new Vector3(72, Random.Range(0.11f, 3f), Random.Range(-6f, 0f));

        if (woff != null)
        {
            woff.transform.position = woffStart; //Make woff positioni random within some space

            woff.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("player"))
        {
            CreateWoffHerd();
        }
    }

    void CreateWoffHerd()
    {
        GameObject woff = PoolObject.SharedInstance.GetPooledObject();
        Vector3 woffStart = new Vector3(72, 0.11f, Random.Range(-6f, 0f));

        if (woff != null)
        {
            woff.transform.position = woffStart; //Make woff positioni random within some space

            woff.SetActive(true);
        }
    }
}
