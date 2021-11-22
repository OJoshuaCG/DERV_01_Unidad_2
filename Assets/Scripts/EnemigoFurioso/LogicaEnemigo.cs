using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEnemigo : MonoBehaviour{    
    
    public GameObject personaje; // personaje a atacar

    void Start() {
               
    }

    void Update() {
        if(personaje != null){
            transform.LookAt(personaje.transform.position);
        }
    }
    
    

}
