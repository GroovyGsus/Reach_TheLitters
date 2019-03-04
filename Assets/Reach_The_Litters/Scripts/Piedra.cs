using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piedra : MonoBehaviour
{
    Rigidbody2D rb;
    private bool activo = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Sirve para que la piedra no se mueva en la plataforma antes de que el Huevo le toque en el Nivel 4 del Mundo 1
        if (col.transform.CompareTag("Huevo") && !activo)
        {
            rb.isKinematic = false;
            activo = true;
        }
    }
}
