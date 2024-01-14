using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private List<GameObject> instatiatedAnimals = new List<GameObject>();
    private float lowerBound = -10f;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // Inbounds animals
        for (int i = instatiatedAnimals.Count - 1; i >= 0; i--)
        {
            GameObject currentAnimal = instatiatedAnimals[i];
            if (currentAnimal.transform.position.z < lowerBound)
            {
                Destroy(currentAnimal);
                instatiatedAnimals.RemoveAt(i);
            }
        }
    }
    void SpawnRandomAnimal()
    {
        // Generate Random Animal Index
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        GameObject newAnimal = Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        instatiatedAnimals.Add(newAnimal);
    }
}
