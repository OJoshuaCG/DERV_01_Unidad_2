using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NO importa la masa del objeto
// La masa no influye en la fuerza que se le aplica
public class Fuerza_Acceleration : MonoBehaviour{    
    Rigidbody rb;
    public float force;
    
    private void Start() {
        rb = GetComponent<Rigidbody>();
        
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        //rb.AddForce(new Vector3(0, 0, 0), ForceMode.Acceleration);
        //rb.AddForce(Vector3.right * 20f, ForceMode.Acceleration); // Coordenadas globales
        rb.AddForce(transform.right * force, ForceMode.Acceleration); // Coordenadas locales
    }

}
