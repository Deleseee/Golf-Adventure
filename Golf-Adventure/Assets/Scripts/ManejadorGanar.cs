using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManejadorGanar : MonoBehaviour
{
    [SerializeField] Text Mensaje;
    void Start()
    {
        if (ManejadorBola.tiros == 1)
        {
            Mensaje.text = "HOYO EN UNOOOO!!!!";
        }
        else
        {
            Mensaje.text = "Has ganado!!! Enhorabuena!!";
        }
    }
    public void Volver()
    {
        SceneManager.LoadScene("Niveles", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Completado");
    }
}
