using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] animalPrefabs;
        //public int animalIndex;
        private float spawnRangeX = 20.0f;
    private float spawnPosZ = 20.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //random gen animal index and spawn position
            Vector3 spawnPos = new Vector3(UnityEngine.Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = UnityEngine.Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation ); 
        }
    }
}
