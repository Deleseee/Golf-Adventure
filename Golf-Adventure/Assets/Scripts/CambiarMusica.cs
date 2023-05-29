using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarMusica : MonoBehaviour
{
    public AudioClip cancion;
    private ManejadorSonido manejadorSonido;
    private GameObject pantalla;
    void Start()
    {
        pantalla = GameObject.Find("CambiarMusica");
        manejadorSonido = FindObjectOfType<ManejadorSonido>();
        if (pantalla.activeSelf)
        {
            cambiarMusica();

        }
    }
    private void cambiarMusica()
    {
        manejadorSonido.CambiarMusica(cancion);
        pantalla.gameObject.SetActive(false);
    }
}
