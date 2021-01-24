using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Initalize variables
    private float speed = 20.0f;
    private float boostSpeed = 40.0f;
    private float turnSpeed = 10.0f;
    private float horizontalInput = 0.0f;
    private float verticalInput = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        MoveForward();

    }

    void MoveForward()
    {
        // Checks for boost button held down, then handle player input and forward movement
        if (Input.GetButton("Boost"))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * boostSpeed * verticalInput);
        } else
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        }

        // Handle player input and turn movement
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
