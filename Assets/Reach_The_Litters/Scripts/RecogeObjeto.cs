using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogeObjeto : MonoBehaviour
{
    Rigidbody2D rbObjeto;
    GameObject objeto;
    bool llevaObjeto = false;
    public Transform patas;
    PathFollow pf;
    AudioSource sonidoTuit;
    // Start is called before the first frame update
    void Start()
    {
        pf = GetComponent<PathFollow>();
        sonidoTuit = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //Sirve para que Tuit recoja los objetos con el tag Huevo, Piedras y Player

        if ((col.gameObject.CompareTag("Huevo") || col.gameObject.CompareTag("Piedras") || col.gameObject.CompareTag("Player")) && transform.childCount == 1)
        {

            llevaObjeto = true;
            col.transform.parent = transform;
            col.transform.position = patas.position;
            objeto = col.gameObject;
            rbObjeto = col.gameObject.GetComponent<Rigidbody2D>();
            rbObjeto.isKinematic = true;
            rbObjeto.velocity = Vector2.zero;


        }
    }

    private void OnMouseDown()
    {
        //Sirve para que al pulsar sobre Tuit suelte el objeto que lleva y que suene el sonido
        if (llevaObjeto && pf.pinchado)

        {
            sonidoTuit.Play();
            rbObjeto.isKinematic = false;
            objeto.transform.parent = null;
            llevaObjeto = false;

        }
    }
}

