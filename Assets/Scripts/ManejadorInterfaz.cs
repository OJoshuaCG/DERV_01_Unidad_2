using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ManejadorInterfaz : MonoBehaviour
{   
    public TextMeshProUGUI usuario;

    public void IniciarJuego(){
        PlayerPrefs.SetString("usu", usuario.text);
        Debug.Log(usuario.text);
        SceneManager.LoadScene(1);
    }
}