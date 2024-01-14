using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public int animalIndex;
    private float lowerBound = -10f;
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
            GameObject newAnimal = Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
            instatiatedAnimals.Add(newAnimal);
            // Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20), animalPrefabs[animalIndex].transform.rotation);
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
