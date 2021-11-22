using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Toma en cuenta la masa del objeto
// La masa influye en la fuerza que se le aplica
public class Fuerza_Impulse : MonoBehaviour{    
    Rigidbody rb;
    public float force;
    
    private void Start() {
        rb = GetComponent<Rigidbody>();

    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        //rb.AddForce(new Vector3(0, 0, 0), ForceMode.Impulse);
        //rb.AddForce(Vector3.right * force, ForceMode.Impulse); // Coordenadas globales
        rb.AddForce(transform.right * force, ForceMode.Impulse); // Coordenadas locales        
    }

}
