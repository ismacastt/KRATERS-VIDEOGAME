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
        rb2d.velocity = transform.right * velocidadBala;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
}
