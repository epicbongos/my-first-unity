using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnCooldownTime = 2.0f;

    // Update is called once per frame
    void Update()
    {
        spawnCooldownTime -= Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && spawnCooldownTime < 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnCooldownTime = 1.0f;
        }
    }
}
