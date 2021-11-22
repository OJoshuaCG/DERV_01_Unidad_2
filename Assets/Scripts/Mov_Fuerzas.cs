using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Fuerzas : MonoBehaviour{    
    Rigidbody rb;
    public float force = 10;

    private void Start() {
        rb = GetComponent<Rigidbody>();
               
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * force, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(transform.forward * -1f * force, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(transform.right * -1 * force, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right* force, ForceMode.Acceleration);
        }

    }

}
