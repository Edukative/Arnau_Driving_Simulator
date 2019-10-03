using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 25.0f;
    private float turnspeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Move the vehicle foward (Z axis)
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        //Move the vehicle right/left (x axis)
        horizontalInput = Input.GetAxis("Horizontal");
        transform .Rotate(Vector3.up * Time.deltaTime * turnspeed * horizontalInput);


    }
}
