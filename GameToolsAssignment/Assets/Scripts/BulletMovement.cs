using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    private Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(fire()); 
	}
    IEnumerator fire()
    {
        rb.AddForce(new Vector3(500,0, 0));
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
