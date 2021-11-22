using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mov_Personaje : MonoBehaviour{    
    
    public TextMeshProUGUI textoVida;
    
    public float speedForce = 10;

    Rigidbody rb;
    private void Start() {
        rb = GetComponent<Rigidbody>();
        
        textoVida.text = 1000.ToString();
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(transform.forward * speedForce, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(transform.forward * -1f * speedForce, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(transform.right * -1 * speedForce, ForceMode.Acceleration);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(transform.right* speedForce, ForceMode.Acceleration);
        }

    }

}
