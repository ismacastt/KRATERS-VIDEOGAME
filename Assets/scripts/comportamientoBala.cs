using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoBala : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float velocidadBala;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rb2d.velocity = Vector2.right * velocidadBala;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
        
    }
}
