using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Funcionamiento : MonoBehaviour{

    public Animator animator;
    public float velocidad;
   public float vida;
    public float danioa;
    public float rango;
    public float veloatack;
    public float rangoatack;
    public Rigidbody2D rb2d;
    public LayerMask capa;
    public Transform player;

    


    // Start is called before the first frame update
    void Start(){


        
    }

    // Update is called once per frame
    void Update(){


        Vector2 objetivo = new Vector2(player.position.x, player.position.y);
        Vector2 nuevaPos = Vector2.MoveTowards(rb2d.position, objetivo, velocidad * Time.deltaTime);

        rb2d.MovePosition(nuevaPos);
        
    }



    void movimiento(){
        



    }


    void ataque(){


    }


    


}
