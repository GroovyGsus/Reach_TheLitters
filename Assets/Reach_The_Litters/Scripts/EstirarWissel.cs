using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstirarWissel : MonoBehaviour
{
    //Declaramos el rigidbody y la velocidad a la que crecerá la serpiente
    Rigidbody2D wis;
    public float speed=2;

    
    public bool estirado = false;

    //Declaramos 2 variables, una que dice cuando se creará el prox objeto vacío 
    //y otra para cuanto esperaremos a crear el proximo (esta última pública, para poder cambiarla desde el editor)
    public float velCol = 2;
    float proxCol = 0;

    //Declaramos el objeto vacio que cogeremos desde el editor
    public GameObject vacio;

    public GameObject megaVacio;

    private Vector3 posicionInicial;

    AudioSource sonido;

    void Start()
    {
        wis = GetComponent<Rigidbody2D>();
        estirado = false;
        posicionInicial = transform.position;
        sonido = GetComponent<AudioSource>();
    }

    void Update()
    {


        //Aqui hacemos que si la serpiente está creciendo, genere los objetos vacios que tendran el collider 
        if (wis.velocity.magnitude > 0 && !estirado)
        {
            //solo genera cuando el tiempo es mayor que proxCol
            if (Time.time > proxCol) 
            {
                GameObject nuevovacio = Instantiate(vacio, transform.position, vacio.transform.rotation); //creamos el objeto vacio
                nuevovacio.transform.parent = megaVacio.transform;
                proxCol = Time.time + velCol; //sumamos a proxcol el tiempo actual para que se "reinicie la cuenta"
            }
           
        }

        if (Mathf.Round(transform.position.x) == Mathf.Round(posicionInicial.x) && estirado)
        {
            wis.bodyType = RigidbodyType2D.Static;
            estirado = false;
            transform.position = posicionInicial;
        }
        




    }

    //aquí hacemos que la serpiente pare de crecer cuando colisiona con un objeto con tag escenario
    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("CHOCANDO" + col.transform.name);
        if (col.gameObject.CompareTag("Escenario") && !estirado)
        {
            wis.bodyType = RigidbodyType2D.Static;
            estirado = !estirado;
        }

       
    }
    
    //Cuando pulsamos sobre la serpiente, suena el sonido y se estira, si ya estña estirada, se encoge
    private void OnMouseDown()
    {
        wis.bodyType = RigidbodyType2D.Dynamic;
        sonido.Play();

        if (!estirado)
        {
            wis.velocity = transform.right * speed;
        }
        else
        {
            int childs = megaVacio.transform.childCount;
            for (int i = 0; i < childs; i++)
            {
                Destroy(megaVacio.transform.GetChild(i).gameObject);
            }
            wis.velocity = transform.right * -speed;
           
        }

      
    }
}
