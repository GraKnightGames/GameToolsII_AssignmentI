using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardPlayerControl : MonoBehaviour {
    public Rigidbody rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(new Vector3(0, 0, 2));
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(new Vector3(0, 0, -2));
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(new Vector3(-2, 0, 0));
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(new Vector3(2, 0, 0));
        }
    }
}
