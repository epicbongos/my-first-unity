using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PropellerSpinX : MonoBehaviour
{
    private float rotateSpeedZ = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(Vector3.right * )
        transform.Rotate(0, 0, rotateSpeedZ);
    }
}
