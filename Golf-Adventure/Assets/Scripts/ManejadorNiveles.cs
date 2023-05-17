using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManejadorNiveles : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Nivel1()
    {
        SceneManager.LoadScene("Mapa1");
    }
    public void Nivel2()
    {
        SceneManager.LoadScene("Mapa2");
    }
    public void Nivel3()
    {
        SceneManager.LoadScene("Mapa3");
    }
}
