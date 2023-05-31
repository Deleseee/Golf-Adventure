using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManejadorSonido : MonoBehaviour
{
    [SerializeField] Slider volumen;
    public GameObject pantalla;
    public AudioSource musica;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Volumen"))
        {
            PlayerPrefs.SetFloat("Volumen", 1);
        }
        else
        {
            volumen.value = PlayerPrefs.GetFloat("Volumen");
        }
    }
    private void Update()
    {
        
        if (!ManejadorMenu.activo)
        {
            pantalla.gameObject.SetActive(true);
        }
        else
        {
            pantalla.gameObject.SetActive(false);
        }
    }
    public void CambiarMusica(AudioClip cancion)
    {
        if (!musica.clip.Equals(cancion)) {
            musica.Stop();
            musica.clip = cancion;
            musica.Play();
        }
    }
    public void CambiarVolumen()
    {
        AudioListener.volume = volumen.value;
    }
    public void Guardar()
    {
        ManejadorMenu.activo = true;
        PlayerPrefs.SetFloat("Volumen", volumen.value);
        if (SceneManager.GetActiveScene().name != "MainMenu")
        {   
            SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        }
    }
}
