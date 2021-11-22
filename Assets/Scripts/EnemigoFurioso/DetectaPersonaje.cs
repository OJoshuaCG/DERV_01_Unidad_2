using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaPersonaje : MonoBehaviour{    
    public GameObject Enemigo;

    LogicaEnemigo logicaE;

    void Start() {
        logicaE = Enemigo.GetComponent<LogicaEnemigo>();               
    }

    void Update() { 
        
    }

    private void OnTriggerEnter(Collider other) {
        string tag = other.gameObject.tag;

        if(tag.Equals("Player")){
            GameObject temporal = GameObject.FindGameObjectWithTag(tag) as GameObject;
            logicaE.personaje = temporal;
        }
    }   

    private void OnTriggerExit(Collider other) {
        string tag = other.gameObject.tag;
        
        if(tag.Equals("Player")){
            logicaE.personaje = null; 
        }
    }

}
