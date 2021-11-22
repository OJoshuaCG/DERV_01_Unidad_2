using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarColor : MonoBehaviour
{
    [SerializeField]
    CambioColorCubo scriptCambioColor;

    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rend.material.color = scriptCambioColor.color;
    }
}
