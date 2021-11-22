using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObjRnd : MonoBehaviour
{
    public float inf = -5;
    public float sup = 5;
    public float y = 0.5f;
    float x, z;

    System.Random rnd = new System.Random();
    
    private void OnCollisionEnter(Collision other) {
        string tag = other.gameObject.tag;
        
        if(tag.Equals("Player")){
            x = GetRndFloat();
            z = GetRndFloat();
            transform.position = new Vector3(x, y, z);
        }
    }

    private float GetRndFloat(){
        double aux = rnd.NextDouble()*(inf-(sup))+(sup);
        return((float)aux);
    }
}
