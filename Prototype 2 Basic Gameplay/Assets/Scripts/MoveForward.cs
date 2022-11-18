using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Variables
    public float flySpeed; // Projectile fly speed
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moving the food forward and applying its speed
        transform.Translate(Vector3.forward * Time.deltaTime * flySpeed);
    }
}
