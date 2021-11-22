using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuerzaBala : MonoBehaviour{    
    Rigidbody rb;
    
    [SerializeField]
    float speedBullet = 10;

    private void Start() {
        rb = GetComponent<Rigidbody>();               
    }

    private void Update() {
        rb.AddForce(transform.forward * speedBullet, ForceMode.Impulse);
    }
}
