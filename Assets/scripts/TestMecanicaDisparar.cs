using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMecanicaDisparar : MonoBehaviour
{
    //Este Script no es definitivo, solo es un test en el que estoy probando la mecanida de disparar para tener el codigo hecho y probar algunas funciones como GameObject dispararBala()

    public GameObject modeloBala;
    public Transform zonaDisparo;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            dispararBala();
        }
        
    }

    void dispararBala()
    {
        GameObject balaInstanciada = Instantiate(modeloBala, zonaDisparo.position, zonaDisparo.rotation);
        Destroy(balaInstanciada, 2);
    }
}
