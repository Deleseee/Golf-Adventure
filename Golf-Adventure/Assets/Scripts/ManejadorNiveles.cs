using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorNiveles : MonoBehaviour
{
    public void Nivel1()
    {
        SceneManager.LoadScene("Mapa1", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Niveles");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Mapa2", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Niveles");
    }
    public void Nivel3()
    {
        SceneManager.LoadScene("Mapa3", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Niveles");
    }
    public void Volver()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Niveles");
    }
}
