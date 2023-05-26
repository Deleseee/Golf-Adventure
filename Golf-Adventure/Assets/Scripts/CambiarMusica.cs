using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarMusica : MonoBehaviour
{
    public AudioClip cancion;
    private ManejadorSonido manejadorSonido;
    void Start()
    {
        manejadorSonido = FindObjectOfType<ManejadorSonido>();
        manejadorSonido.CambiarMusica(cancion);
    }
    void Update()
    {

    }
}
