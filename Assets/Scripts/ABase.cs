using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ABase : MonoBehaviour{    
    Rigidbody rb;
    public float force;

    private void Start() {
        rb = GetComponent<Rigidbody>();
               
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        
    }

}
