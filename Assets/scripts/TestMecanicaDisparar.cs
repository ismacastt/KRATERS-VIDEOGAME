using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMecanicaDisparar : MonoBehaviour
{
    //Este Script no es definitivo, solo es un test en el que estoy probando la mecanida de disparar para tener el codigo hecho y probar algunas funciones como GameObject dispararBala()

    public GameObject modeloBala;
    public Transform dispararDer, dispararIzq, dispararArr, dispararAba;

    private float tiempoEntreDisparos;
    public float comenzarTiempoEntreDisparos;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(tiempoEntreDisparos <= 0){
            if (Input.GetKey(KeyCode.RightArrow))
            {
                dispararBala(dispararDer);
                tiempoEntreDisparos = comenzarTiempoEntreDisparos;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dispararBala(dispararIzq);
                tiempoEntreDisparos = comenzarTiempoEntreDisparos;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                dispararBala(dispararArr);
                tiempoEntreDisparos = comenzarTiempoEntreDisparos;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                dispararBala(dispararAba);
                tiempoEntreDisparos = comenzarTiempoEntreDisparos;
            }
        }
        else
        {
            tiempoEntreDisparos -= Time.deltaTime;
        }
       
    }

    void dispararBala(Transform spawnBala)
    {
        GameObject balaInstanciada = Instantiate(modeloBala, spawnBala.position, spawnBala.rotation);
        Destroy(balaInstanciada, 2);
    }
}
