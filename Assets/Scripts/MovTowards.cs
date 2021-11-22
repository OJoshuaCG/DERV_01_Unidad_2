using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTowards : MonoBehaviour{    
    public GameObject ObjDestino;
    public float speed = 10;

    void Start() {
                       
    }

    
    void Update() {
        Vector3 origen = transform.position;
        Vector3 destino = ObjDestino.transform.position;

        destino.z -= 3.0f;       

        transform.LookAt(destino);

        transform.position = Vector3. MoveTowards(origen, destino, speed * Time.deltaTime);

        
        //transform.position = Vector3.Lerp(origen, destino, speed * Time.deltaTime);

        /*
        Vector3 currentVelocity = new Vector3(0f, 0f, 0f);
        transform.position = Vector3.SmoothDamp(origen, destino, ref currentVelocity, speed * Time.deltaTime);
        */

        float distancia = Vector3.Distance(origen, destino);

    }    
    

}
