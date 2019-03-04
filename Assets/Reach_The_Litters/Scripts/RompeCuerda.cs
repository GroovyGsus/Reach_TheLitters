using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RompeCuerda : MonoBehaviour
{

    HingeJoint2D jointCuerda;
    SpriteRenderer sr;
    LineRenderer lr;
    bool conectado = true;
    public AudioClip sonidoRomperCuerda;

    // Start is called before the first frame update
    void Start()
    {
        //Coge los diferentes nodos de la cuerda
        sr = GetComponent<SpriteRenderer>();
        jointCuerda = GetComponent<HingeJoint2D>();
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Se dibuja la cuerda
        if (conectado)
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, jointCuerda.connectedBody.transform.position);
        }
       
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Cuando la cuerda colisona con el Mouse y además se está pulsando el click izquierdo, se destruye la cuerda y suena el sonido de cuerda rota
        if (col.gameObject.tag == "Mouse" && Input.GetMouseButton(0))
        {
            /*
            conectado = false; 
            //gameObject.GetComponent<HingeJoint2D>();
            Destroy(jointCuerda);
            Destroy(lr);
            Destroy(sr);*/
            if(sonidoRomperCuerda != null)
            {
                AudioSource.PlayClipAtPoint(sonidoRomperCuerda, transform.position);
            }
            Destroy(transform.parent.gameObject);
            
        }
        
           
        

    }
}
