using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMady : MonoBehaviour
{
    AudioSource sonido;
    bool piar = true;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (piar)
        {
            piar = false;
            Invoke("Piar", Random.Range(2,5));
        }
    }

    public void Piar()
    {
        piar = true;
        sonido.Play();
    }
}
