using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Variables
    public GameObject[] animalPrefabs; // Array to store multiple animals
    private float spawnRangeX = 13; // Animal's x-axis spawn range limit
    private float spawnRangeZ = 20; // Anima's z-axis spawn range limit
    private float startDelay = 2; // Animal's start spawn delay
    private float spawnInterval = 1.5f; // Animal's spawn interval

    // Start is called before the first frame update
    void Start()
    {
        // Adding a delay and interval to SpawnRandomAnimal function/method
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        // InvokeRepeating method is to add a start delay and call interval on a function/method
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Spawn random animal function
    void SpawnRandomAnimal()
    {
        // Getting a random animal using their index/element number and storing it to a local variable
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Creating new position to spawn the animals and applying the spawn limit
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);

        // Creating a copy of animal based on the given index,
        // and spawning it to the new position with spawn limits
        Instantiate(animalPrefabs[animalIndex], spawnPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
