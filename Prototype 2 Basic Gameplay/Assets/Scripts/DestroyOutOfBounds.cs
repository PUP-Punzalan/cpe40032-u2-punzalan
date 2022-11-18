using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Variables
    private float topBoundary = 30.0f; // Food limit boundary
    private float lowerBoundary = -10.0f; // Animals limit boundary

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Destroys the object when it reaches the top boundary
        if (transform.position.z > topBoundary)
        {
            Destroy(gameObject);
        }
        // Destroys the object when it reaches the lower boundary
        else if (transform.position.z < lowerBoundary)
        {
            // Prints a message in the console
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
