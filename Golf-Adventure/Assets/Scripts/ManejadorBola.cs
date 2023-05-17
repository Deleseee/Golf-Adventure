using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManejadorBola : MonoBehaviour
{
    public GameObject bola;
    private Vector3 position;
    private bool muerte;
    public static int tiros;
    [SerializeField] Text ContTiro;
    private Scene escena;

    private void Start()
    {
        escena = SceneManager.GetActiveScene();
        muerte = false;
        tiros = 0;
    }
    private void Update()
    {
        if (tiros == 35)
        {
            NivelNoCompletado();
        }
        ContTiro.text = tiros.ToString();
        if (Input.GetMouseButtonUp(0))
        {
            position = bola.transform.position;
            tiros++;
        }
        if (muerte)
        {
            bola.transform.position = position;
            muerte = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name=="Muerte")
        {
            muerte = true;
        }
        if (collision.gameObject.name == "hoyo")
        {
            NivelCompletado();
        }
    }
    public void NivelCompletado()
    {
        SceneManager.LoadScene("Completado");
    }
    public void NivelNoCompletado()
    {
        ManejadorNoCompletado.nivel = escena.name;
        SceneManager.LoadScene("NoCompletado");
    }
}
