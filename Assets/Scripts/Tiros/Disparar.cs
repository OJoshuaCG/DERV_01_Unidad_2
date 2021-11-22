using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour{   

    [SerializeField]
    GameObject posSpawner;
    [SerializeField]
    GameObject bullet;

    int i = 0;
    
    private void Start() {
       
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.F)){
            GameObject bull = Instantiate(bullet, posSpawner.transform.position, posSpawner.transform.rotation);
            
            bull.name = "Municion_" + i++;
            Destroy(bull, 5);
        }
    }
}
