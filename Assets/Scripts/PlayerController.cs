﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //private variables
    private float speed = 20.0f;
    private float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where you gewt player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //moves vehicle forward based on player input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //rotates vehicle left/right based on player input
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput* Time.deltaTime);
    }
}