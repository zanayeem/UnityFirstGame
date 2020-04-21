using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardForce = 500f;
    public float SideForce = 75f;
    // Start is called before the first frame update
    void Start()
    {
        //rb.useGravity = true;
        //rb.AddForce(200, 0, 0);
    }

    // We will use this method to mess around with the physics
    void FixedUpdate()
    {
        //if (Input.GetKey("w"))
        //{
            rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        //}
        
        if (Input.GetKey("d")) {
            rb.AddForce(SideForce * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-ForwardForce * Time.deltaTime);
        }
    }

    void Update()
    { 
    
    }
}
