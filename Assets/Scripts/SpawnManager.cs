using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float lowerBound = -10f;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private List<GameObject> instatiatedAnimals = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Generate Random Animal Index
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            GameObject newAnimal = Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
            instatiatedAnimals.Add(newAnimal);
        }
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
}
