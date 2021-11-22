using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMouse : MonoBehaviour{    
    Rigidbody rb;
    public float speedX = 1;
    public float speedY = 1;
    public int clamp = 10;

    float ejeRotacionObj;
    float ejeRotacionCam;

    public GameObject camara;

    private void Start() {
        rb = GetComponent<Rigidbody>();
               
    }

    private void Update() {
        
    }

    private void FixedUpdate() {
        ejeRotacionObj = Input.GetAxis("Mouse X");
        ejeRotacionCam += Input.GetAxis("Mouse Y") * speedX;

        this.transform.Rotate(0, ejeRotacionObj * speedY, 0);
        
        ejeRotacionCam = Mathf.Clamp(ejeRotacionCam, clamp * -1, clamp);
        camara.transform.localEulerAngles = new Vector3(-ejeRotacionCam * speedX, 0f, 0f);
    }

}
