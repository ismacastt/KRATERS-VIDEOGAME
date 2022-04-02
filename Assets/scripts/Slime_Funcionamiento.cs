using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Funcionamiento : MonoBehaviour
{

    public Animator animator;
    public float velocidad;
    public float velocidadatras;
    public float vida;
    public float datack;
    public float distanciaplayer;
    public float vision;
    public float visionatras;
    public float veloatack;
    public float rangoatack;
    public Rigidbody2D rb2d;
    public LayerMask capa;
    public Transform player;




    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        distanciaplayer = Vector2.Distance(player.position, rb2d.position);

        if (distanciaplayer < vision && distanciaplayer > visionatras && distanciaplayer > rangoatack)
        {

            Vector2 objetivo = new Vector2(player.position.x, player.position.y);
            Vector2 nuevaPos = Vector2.MoveTowards(rb2d.position, objetivo, velocidad * Time.deltaTime);

            rb2d.MovePosition(nuevaPos);



        }

        else if (distanciaplayer < vision && distanciaplayer > visionatras && distanciaplayer <= rangoatack)
        {

            Vector2 objetivo = new Vector2(player.position.x, player.position.y);
            Vector2 nuevaPos = Vector2.MoveTowards(rb2d.position, objetivo, 0 * Time.deltaTime);

            rb2d.MovePosition(nuevaPos);
        }

        else if (distanciaplayer < visionatras)
        {

            Vector2 objetivo = new Vector2(player.position.x, player.position.y);
            Vector2 nuevaPos = Vector2.MoveTowards(rb2d.position, objetivo, velocidadatras * Time.deltaTime);

            rb2d.MovePosition(nuevaPos);

        }


    }


    void ataque()
    {


    }


    private void OnDrawGizmos() {

        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(transform.position,rangoatack);
         Gizmos.DrawWireSphere(transform.position,vision);
        Gizmos.DrawWireSphere(transform.position,visionatras);
    }





}
