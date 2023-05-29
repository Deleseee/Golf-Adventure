using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorMenu : MonoBehaviour
{
    public static bool activo = true;
    private void Start()
    {
        if (SceneManager.GetActiveScene().name != "Musica")
        {
            SceneManager.LoadScene("Musica", LoadSceneMode.Additive);
        }
    }
    public void Jugar()
    {
        SceneManager.LoadScene("Niveles", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("MainMenu");
    }
    public void Salir()
    {
        Application.Quit();
    }
    public void Opciones()
    {
        activo = false;
        SceneManager.UnloadSceneAsync("MainMenu");
    }
}
