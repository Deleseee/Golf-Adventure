using System.Collections;
using System.Collections.Generic;
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
        }else if (ManejadorBola.tiros <= 20)
        {
            Mensaje.text = "Has ganado!!! Enhorabuena!!";
        }
        else
        {
            Mensaje.text = "Has tirado mucho, esfuerzate mas >:(";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Volver()
    {
        SceneManager.LoadScene("niveles");
    }
}
