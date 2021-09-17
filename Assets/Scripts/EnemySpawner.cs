using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    Vector3[] Spawnpoint = new [] { new Vector3(-4.6500001f, 0f, 0f), new Vector3(0f, -4.85f, 0f), new Vector3(4.8000001f, 0.0f, 0f), new Vector3(0f, 4.85f, 0f) };
    //System.Random random;
    //int randomnumber;

    IEnumerator spawnguy()
    {



        while(true)
        {
            //int num = random.Next(0, 3);
            int num = UnityEngine.Random.Range(0, 4);
            Instantiate(prefab, Spawnpoint[num], Quaternion.identity);

            yield return new WaitForSeconds(1f);

        }
        
    }

    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnguy());
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
