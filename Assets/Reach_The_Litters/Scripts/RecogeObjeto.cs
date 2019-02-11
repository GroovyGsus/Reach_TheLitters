using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogeObjeto : MonoBehaviour
{
    Rigidbody2D rbObjeto;
    GameObject objeto;
    bool llevaObjeto = false;

    AudioSource sonidoTuit;

    // Start is called before the first frame update
    void Start()
    {
        sonidoTuit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Huevo") || col.gameObject.CompareTag("Piedras") || col.gameObject.CompareTag("Player"))
        {

            llevaObjeto = true;
            col.transform.parent = transform;
            objeto = col.gameObject;
            rbObjeto = col.gameObject.GetComponent<Rigidbody2D>();
            rbObjeto.isKinematic = true;
            rbObjeto.velocity = Vector2.zero;


        }
    }

    private void OnMouseDown()
    {
        sonidoTuit.Play();

        if (llevaObjeto)
        {
            rbObjeto.isKinematic = false;
            objeto.transform.parent = null;
            llevaObjeto = false;

        }
    }
}

