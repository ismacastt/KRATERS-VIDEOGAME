using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPlayer : MonoBehaviour
{
    //Controlará nuestra velocidad
    public float velocidad;
    //Accede al simulador de fisicas2d del player, que le he colocado previamente.
    public Rigidbody2D rb2d;
    //Vector que usaremos mas adelante
    private Vector2 direccionMov;

    // Como es el primer codigo voy a comentar todo pero las funciones como Start y los Update los voy a comentar solo esta vez porque siempre funcionan igual

    //Tanto Start como Update se ejecutan solos, no hay que llamarlos

    //La void Start se llama una vez y es al principio del frame o en cuanto se ejecuta el juego 
    //En este caso no la necesito de momento pero la voy a dejar vacia para explicarla
    void Start()
    {
        
    }

    // Los Update se llaman siempre en cada frame del juego. En este caso llamo a la funcion Reconocer teclas y la ejecutará en cada fotograma del juego 
    void Update()
    {
        ReconocerTeclas();
    }

    /*El fixed Update lo utilizaré para calcular las fisicas y movimientos. Se llama fixed Update porque nos soluciona un error muy basico.
    Con un ejemplo se entenderá mejor:

    Si tu estas jugando a un juego a 30 fps y otro a 60 fps el Update normal se va a ejecutar mas veces cuantos
    mas frame halla. A la hora de detectar los Input(pulsar teclas) y otras acciones no pasaría nada, es más, el update normal se usa siempre.

    El problema llega cuando tienes que añadir fuerzas o velocidades (cualquier cosa que tenga fisicas).Si calculase la funcion Mover() en un Update normal
    la velocidad del personaje cambiaría dependiendo de los fps(en mi ordenador lo veria moviendose a una velocidad de 12 por ejemplo y en otro se vería de 20).
    Hay otras maneras de solucionarlo sin usar el Fixed Update pero esta vez lo voy a usar.*/

    void FixedUpdate()
    {
        Mover();
    }

    /*
     La funcion reconocerTeclas() se encarga de procesar cada vez que pulsamos una tecla del teclado. En este caso utilizo los Axis de unity
     que son inputs que vienen predeterminados y hacen mas facil la tarea. Así no tenemos que decirle las teclas que queremos, solo con Horizontal
     y vertical reconoce que queremos mover cuando pulsemos AWSD o las flechas del teclado.

     Los dos float que declaro almacenan el numero 1 cuando pulsamos esa tecla y 0 si no la estamos pulsando. Luego lo guardo todo en un vector2 y lo normalizo para que no halla problemas al moverme en diagonal.
    */

    void ReconocerTeclas()
    {
        float moverX = Input.GetAxisRaw("Horizontal");
        float moverY = Input.GetAxisRaw("Vertical");

        direccionMov = new Vector2(moverX,moverY).normalized;
    }

    /*
     La funcion Mover() aplica los 1 recogidos de los input y los multiplica por el valor de la variable velocidad. 
     Todo esto sobre el reb2 velocity que es el componente que accede a las velocidades de nuestro rigidbody2d.
    */

    void Mover()
    {
        rb2d.velocity = new Vector2(direccionMov.x * velocidad, direccionMov.y *velocidad);
    }

}
