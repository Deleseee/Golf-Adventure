using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguimiento : MonoBehaviour
{
    float x,y =0f;
    public float velocidad = 2f;
    public Rigidbody bola;
    public float disparo = 2f;
    public LineRenderer linea;
    void Update()
    {
        transform.position = bola.position;
        if (Input.GetMouseButton(1))
        {
            x += Input.GetAxis("Mouse X")*velocidad;
            y += Input.GetAxis("Mouse Y")*velocidad;
            transform.rotation = Quaternion.Euler(0f, x,0f);
            linea.gameObject.SetActive(true);
            linea.SetPosition(0, transform.position);
            linea.SetPosition(1, transform.position+transform.forward*2f);
        }
        if (Input.GetMouseButtonUp(0))
        {
            bola.velocity = transform.forward*disparo;
            linea.gameObject.SetActive(false);
        }

    }

}
