using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuerza_VelocityChange : MonoBehaviour{    
    Rigidbody rb;
    public float force;
    
    private void Start() {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        //rb.AddForce(new Vector3(0, 0, 0), ForceMode.VelocityChange);
        //rb.AddForce(Vector3.right * force, ForceMode.VelocityChange); // Coordenadas globales
        rb.AddForce(transform.right * force, ForceMode.VelocityChange); // Coordenadas locales        
    }

}
