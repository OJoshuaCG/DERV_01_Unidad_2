using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetImpact : MonoBehaviour
{   
    [SerializeField]
    TextMeshProUGUI txt_puntaje;

    private void OnCollisionEnter(Collision other) {
        string tag = other.gameObject.tag;

        if(tag.Equals("Municion")){
            int puntaje = int.Parse(txt_puntaje.text);
            puntaje++;
            txt_puntaje.text = puntaje.ToString();

            GameObject obj = GameObject.Find(other.gameObject.name);
            Destroy(obj);
        }
    }
}
