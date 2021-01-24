﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpin : MonoBehaviour
{
    // Initialize Variables
    public GameObject propeller;
    public float propSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        propeller.transform.Rotate(Vector3.forward * propSpeed);
    }
}
