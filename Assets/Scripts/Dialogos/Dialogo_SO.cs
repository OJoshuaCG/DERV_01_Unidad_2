using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Dialogo_SO : MonoBehaviour
{   
    [SerializeField]
    Dialogo dialogo;
    
    public int indexActual;
    public GameObject contenedorImagen;
    public Image image;

    [SerializeField]
    public GameObject contenedorDialogo;

    [SerializeField]
    public TextMeshProUGUI texto;

    [SerializeField]
    Image imgDefecto;

    

    private void Awake() {
        contenedorImagen = GameObject.Find("Contenedor");
        image = contenedorImagen.GetComponentInChildren<Image>();
    }

    void Start(){
        indexActual = -1;        
    }
    
    
    float largo;
    bool inChat = false;

    void Update(){    
        if(!inChat){
            if(Input.GetKeyDown(KeyCode.F)){ // atras
                contenedorDialogo.SetActive(true);
                if(indexActual > 0){
                    setMessage(-1); 
                }                              
            }   
            
            if(Input.GetKeyDown(KeyCode.G)){ // delante
                contenedorDialogo.SetActive(true);
                if(indexActual < dialogo.getCantidadMensajes()-1){
                    setMessage(+1);
                }
            }                

            if(Input.GetKeyDown(KeyCode.Q)){
                contenedorDialogo.SetActive(false);
                indexActual = -1;                
            }
        }
    }
    

    private void setMessage(int puntero){
        indexActual += puntero;
        image.sprite = dialogo.getDatosPersonaje(indexActual).personaje.imagen; // la forma mas correcta
        //image.sprite = dialogo.mensaje[indexActual].personaje.imagen;         
        texto.text = dialogo.getDatosPersonaje(indexActual).dialogo;    
                    
        inChat = true;
        largo = texto.text.Length;
        StartCoroutine("mostrarTexto");
    }

    IEnumerator mostrarTextoAntes(){       
        while(true){            
            float largo = texto.text.Length;
            if(texto.maxVisibleCharacters < largo){
                texto.maxVisibleCharacters += 1;
            }
            Debug.Log("Ejecucion");
            yield return new WaitForSeconds(0.05f);
        }
    }

    // 1. Detener corrutina una vez que termina su objetivo
    // 2. Asegurar de no mostrar un mensaje hasta que 
    //    el anterior haya sido mostrado completamente


    IEnumerator mostrarTexto(){        
        while(texto.maxVisibleCharacters < largo){
            texto.maxVisibleCharacters += 1;
            Debug.Log("Ejecucion");
            yield return new WaitForSeconds(0.05f);
        }
        inChat = false;
        StopCoroutine("mostrarTexto");
    }

}