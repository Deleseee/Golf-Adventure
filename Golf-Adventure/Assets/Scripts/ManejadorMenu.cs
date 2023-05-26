using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorMenu : MonoBehaviour
{
    public static bool activo = true;
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
