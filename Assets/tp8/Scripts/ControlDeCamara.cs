using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeCamara : MonoBehaviour
{
    public Transform objetivo; // El objeto al que seguir (puede ser tu terreno o cualquier otro objeto)
    public float velocidadRotacion = 2.0f;
    public float velocidadZoom = 5.0f;

    void Update()
    {
        // Rotaci�n de la c�mara alrededor del objetivo
        transform.RotateAround(objetivo.position, Vector3.up, Input.GetAxis("Horizontal") * velocidadRotacion);

        // Zoom de la c�mara
        transform.Translate(Input.GetAxis("Vertical") * velocidadZoom * Vector3.forward);

        // Mantener la c�mara mirando al objetivo
        transform.LookAt(objetivo.position);
    }
}
