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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }

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
