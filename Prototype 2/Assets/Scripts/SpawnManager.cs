using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalArray;
    private float spawnRangeX = 10;
    private float spawnPosZ = 20;
    private float spawnStartTime = 2;
    private float spawnRepeatTime = 2;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnStartTime, spawnRepeatTime);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0, spawnPosZ);
            int animalIndex = Random.Range(0, animalArray.Length);
            Instantiate(animalArray[animalIndex], spawnPos,
            animalArray[animalIndex].transform.rotation);
    }
}
