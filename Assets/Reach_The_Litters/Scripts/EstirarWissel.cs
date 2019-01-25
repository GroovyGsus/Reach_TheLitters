using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstirarWissel : MonoBehaviour
{
    //Declaramos el rigidbody y la velocidad a la que crecerá la serpiente
    Rigidbody2D wis;
    public float speed=2;

    //Declaramos 2 variables, una que dice cuando se creará el prox objeto vacío 
    //y otra para cuanto esperaremos a crear el proximo (esta última pública, para poder cambiarla desde el editor)
    public float velCol = 2;
    float proxCol = 0;

    //Declaramos el objeto vacio que cogeremos desde el editor
    public GameObject vacio;

    void Start()
    {
        wis = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Aqui hacemos que cuando pulsamos la serpiente empiece a crecer
        if (Input.GetMouseButton(0))
        {
            wis.velocity = new Vector2(speed, speed);          
        }

        //Aqui hacemos que si la serpiente está creciendo, genere los objetos vacios que tendran el collider 
        if(wis.velocity.magnitude > 0)
        {
            //solo genera cuando el tiempo es mayor que proxCol
            if (Time.time > proxCol) 
            {
                vacio = Instantiate(vacio, transform.position, vacio.transform.rotation); //creamos el objeto vacio
                proxCol = Time.time + velCol; //sumamos a proxcol el tiempo actual para que se "reinicie la cuenta"
            }
           
        }
    }

    //aquí hacemos que la serpiente pare de crecer cuando colisiona con un objeto con tag escenario
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Escenario"))
        {
            wis.bodyType = RigidbodyType2D.Static;          
        }
    }
}
