using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Vehicle speed modifier
    public float speed = 10.0f;
    public float boostSpeed = 10.0f;
    public float turnSpeed = 10.0f;
    public float horizontalInput = 0.0f;
    public float verticalInput = 0.0f;

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
        // Handle player input and forward movement
        if(Input.GetButton("Boost"))
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
