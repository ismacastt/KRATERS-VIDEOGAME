using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidadMovimiento = 5f;
    public Rigidbody2D rb2d;

    public Camera camara;

    Vector2 movimiento;
    Vector2 posRaton;


    void Update()
    {
        movimiento.x = Input.GetAxisRaw("Horizontal");
        movimiento.y = Input.GetAxisRaw("Vertical");

        posRaton = camara.ScreenToWorldPoint(Input.mousePosition);
    }


    void FixedUpdate()
    {

        rb2d.MovePosition(rb2d.position + movimiento * velocidadMovimiento * Time.fixedDeltaTime);
        
        Vector2 mirarDireccion = posRaton - rb2d.position;

        float angulo = Mathf.Atan2(mirarDireccion.y,mirarDireccion.x) * Mathf.Rad2Deg - 90f;

        rb2d.rotation = angulo;

    }
}
