using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManejadorLogica : MonoBehaviour
{   
    public TextMeshProUGUI usuario;
    public int contador;

    private void Start() {
        contador = 10;
        StopAllCoroutines();
        StartCoroutine("auxiliarTest");
    }

    IEnumerator auxiliarTest(){
        while(true){            
            contador--;
            if(contador == 0){
                SceneManager.LoadScene(2);
            }

            yield return new WaitForSeconds(1.0f);
        }
        StopAllCoroutines();
    }

    public void IniciarJuego(){
        PlayerPrefs.SetString("usu", usuario.text);
        Debug.Log(usuario.text);
        SceneManager.LoadScene(1);
    }
}