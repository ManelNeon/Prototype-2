using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOf : MonoBehaviour
{
    float topBound = 30;

    float lowerBound = -10;

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
