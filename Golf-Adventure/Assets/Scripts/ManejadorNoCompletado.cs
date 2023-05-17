using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorNoCompletado : MonoBehaviour
{
    static public string nivel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JugarDeNuevo()
    {
        SceneManager.LoadScene(nivel);
    }
    public void Salir()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
