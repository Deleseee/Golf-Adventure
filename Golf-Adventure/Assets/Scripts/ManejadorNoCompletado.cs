using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorNoCompletado : MonoBehaviour
{
    static public string nivel;
    public void JugarDeNuevo()
    {
        SceneManager.LoadScene(nivel, LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("NoCompletado");
    }
    public void Salir()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("NoCompletado");
    }
}
