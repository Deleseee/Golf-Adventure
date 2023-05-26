using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seguimiento : MonoBehaviour
{
    float x = 0f;
    float velocidad = 5f;
    public Rigidbody bola;
    float disparo = 5f;
    public LineRenderer linea;
    [SerializeField] Text Potencia;
    private void Start()
    {
        velocidad = 5f;
        disparo = 5f;
    }
    void Update()
    {
        Potencia.text = disparo.ToString()+"%";
        transform.position = bola.position;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if (disparo < 100f)
            {
                disparo += 5f;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (disparo > 5f)
            {
                disparo -= 5f;
            }
        }
        if (Input.GetMouseButton(0))
        {
            if (bola.velocity.magnitude < 1f)
            {
                x += Input.GetAxis("Mouse X") * velocidad;
                transform.rotation = Quaternion.Euler(0f, x, 0f);
                linea.gameObject.SetActive(true);
                linea.SetPosition(0, transform.position);
                linea.SetPosition(1, transform.position + transform.forward * 2f);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            if (bola.velocity.magnitude < 1f)
            {
                bola.velocity = transform.forward * disparo;
                linea.gameObject.SetActive(false);
            }
        }

    }

}
