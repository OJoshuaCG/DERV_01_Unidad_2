using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster_Code : MonoBehaviour{    
    Rigidbody rb;
    public float force;

    private void Start() {
        rb = GetComponent<Rigidbody>();
               
    }

    private void Update() {
        Vector3 origen = transform.position;
        // Hacia izquierda derecha
        //Vector3 direccion = transform.forward;

        // Arriba y abajo
        Vector3 direccion = new Vector3(0, -1, 0);

        RaycastHit hit; //Almacena informacion de la colision. Consultar: https://docs.unity3d.com/
        float distancia = 10f; //Distancia maxima del rayo. Si no se establece es Infinito
        //int layerMask;  // Capa con la que se desea validar la colision (No utilizado de momento)
                        // Por defecto revisa todas las capas

        //Determina si la colisión considerá a los objetos
        //QueryTriggerInteraction queryTrigger = QueryTriggerInteraction.Collide; 

        float duracionRayo = 1;

        if(Physics.Raycast(origen, direccion, out hit, distancia)){
            // hit. <- Para extraer información del objeto con el que se colisiono
            Debug.DrawRay(origen, direccion * hit.distance, Color.yellow, duracionRayo);

            /*
            string nombre = hit.collider.gameObject.name;
            GameObject obj = GameObject.Find(nombre);
            Destroy(obj);
            */
        }    
        else{
            Debug.DrawRay(origen, direccion * distancia, Color.red, duracionRayo);
        }

    }

    private void FixedUpdate() {
        
    }

    

    private void OnDrawGizmos(){
        Gizmos.color = Color.green;

        // Origen , Direccion
        Gizmos.DrawRay(transform.position, transform.forward * 10f);
    }

}
