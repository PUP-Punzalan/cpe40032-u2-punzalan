using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Variables
    public float horizontalInput; // To get the user's horizontal input
    public float walkSpeed; // Player's walk speed
    public float xRange = 13.0f; // Player's x-axis movement limit

    // Game Objects
    public GameObject foodPrefab; // To get the food projectile object

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Adding distance limit to the player in order for it to stay in the frame
        if (transform.position.x < -xRange) // Left boundary
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) // Right boundary
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Getting user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // Applying the Player's speed when a left or right key pressed
        transform.Translate(Vector3.right * Time.deltaTime * walkSpeed * horizontalInput);

        // Spawn the food projectile where the Player is at
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Make a copy of food projectile
            // Applying the Player's position to the food projectile
            // Applying the food projectile's rotation
            Instantiate(foodPrefab, transform.position, foodPrefab.transform.rotation);
        }
    }
}
