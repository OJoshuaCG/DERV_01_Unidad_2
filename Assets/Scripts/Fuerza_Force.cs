using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// La masa influye en la fuerza aplicada en el objeto
public class Fuerza_Force : MonoBehaviour{    
    Rigidbody rb;
    public float force;

    private void Start() {
        rb = GetComponent<Rigidbody>();
               
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        //rb.AddForce(new Vector3(0, 0, 0), ForceMode.Force);
        //rb.AddForce(Vector3.right * force, ForceMode.Force); // Coordenadas globales
        rb.AddForce(transform.right * force, ForceMode.Force); // Coordenadas locales
    }

}
