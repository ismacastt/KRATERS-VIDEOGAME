using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMecanicaDisparar : MonoBehaviour
{
    //Este Script no es definitivo, solo es un test en el que estoy probando la mecanida de disparar para tener el codigo hecho y probar algunas funciones como GameObject dispararBala()

    public float velocidadBala;
    public GameObject modeloBala;
    public Transform zonaDisparo;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject balaInstanciada = dispararBala();
            balaInstanciada.GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidadBala;
        }
    }

    GameObject dispararBala()
    {
        GameObject balaInstanciada = Instantiate(modeloBala, zonaDisparo.position, zonaDisparo.rotation);
        Destroy(balaInstanciada, 2);

        return balaInstanciada;
    }
}
