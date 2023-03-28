using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
// Start is called before the first frame update
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }

    }
}
