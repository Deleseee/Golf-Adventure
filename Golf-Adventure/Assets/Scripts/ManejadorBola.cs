using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManejadorBola : MonoBehaviour
{
    public Rigidbody bola;
    private Vector3 position;
    private bool muerte;
    public static int tiros;
    [SerializeField] Text ContTiro;
    private Scene[] escena;
    private string nombreEscena;
    ConstantForce gravedad;
    public AudioSource SonidoTiro;
    public AudioClip cancion;

    private void Start()
    {
        muerte = false;
        tiros = 0;
        bola.useGravity = true;
        gravedad = bola.GetComponent<ConstantForce>();
        gravedad.force = new Vector3(0, -550f, 0);
    }
    private void Update()
    {
        escena = SceneManager.GetAllScenes();
        //ContTiro.text = escena.name.Length.ToString();
        for (int i = 0; i < escena.Length; i++)
        {
            if (escena[i].name.Equals("Mapa1"))
            {
                nombreEscena = "Mapa1";
            }
            else if (escena[i].name.Equals("Mapa2"))
            {
                nombreEscena = "Mapa2";
            }
            else if (escena[i].name.Equals("Mapa3"))
            {
                nombreEscena = "Mapa3";
            }
        }
        if (tiros == 35)
        {
            NivelNoCompletado();
        }
        ContTiro.text = tiros.ToString();
        if (Input.GetMouseButtonUp(0))
        {
            if (bola.velocity.magnitude < 1f)
            {
                SonidoTiro.clip = cancion;
                SonidoTiro.Play();
                position = bola.transform.position;
                tiros++;

            }
        }
        if (muerte)
        {
            bola.transform.position = position;
            muerte = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Muerte")
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
        SceneManager.LoadScene("Completado", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(nombreEscena);
    }
    public void NivelNoCompletado()
    {
        ManejadorNoCompletado.nivel = nombreEscena;
        SceneManager.LoadScene("NoCompletado", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync(nombreEscena);
    }
}
