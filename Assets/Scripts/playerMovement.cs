using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    //translation and rotation speeds
    public float speed = 5.0f;
    public float turnSpeed = 25.0f;

    //translation and rotation inputs
    public float translateInput;
    public float rotateInput;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //The movement controls are based on the WASD keys
        
        //Translation input keys: "w" forward, "s" backward
        translateInput = Input.GetAxis("Vertical");

        //Rotation input keys: "a" left, "d" right
        rotateInput = Input.GetAxis("Horizontal");

        /* 
        Inputs returned are either 1 or -1, 
        multiplying them by the speed vector retruns 
        either positive or negative movement

        "Time.deltaTime" avoids changes in values due to
        change in framerate by returning time in seconds between
        last frame and current frame
        */
        transform.Translate(Vector3.forward * Time.deltaTime * speed * translateInput);
        transform.Rotate(Vector3.up, turnSpeed * rotateInput * Time.deltaTime);
    }
}
