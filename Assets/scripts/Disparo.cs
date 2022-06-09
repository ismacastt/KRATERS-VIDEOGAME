using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public Transform pDisparo;
    public GameObject prefabBala;

    public float balaForce = 20f;

    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            disparar();
        }


    }


    void disparar()
    {
        GameObject bala = Instantiate(prefabBala, pDisparo.position, pDisparo.rotation);
        Rigidbody2D rb2d = bala.GetComponent<Rigidbody2D>();
        rb2d.AddForce(pDisparo.up * balaForce, ForceMode2D.Impulse);
    }


}
