using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flecha_LookAt : MonoBehaviour
{
    public GameObject objMirar;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(objMirar.transform);

        /*
        Vector3 pos = objMirar.transform.position;
        pos.y = 0;
        transform.LookAt(pos);
        */
    }
}
