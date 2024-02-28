using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [Header("Animals")]
    [SerializeField] GameObject[] animalPrefabs;

    [Header("SpawnLocations")]
    [SerializeField] float spawnRangeX = 20;

    [SerializeField] float spawnPosZ = 20;

    void Update()
    {
        AnimalSpawn();
    }

    //Spawn Animals
    void AnimalSpawn()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);

            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
