using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoMady : MonoBehaviour
{
    AudioSource sonido;
    public AudioClip normal;
    public AudioClip triste;
    public AudioClip ganar;
    bool piar = true;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Maddy pia de forma aleatoria entre 5 y 15 segundos
        if (piar)
        {
            piar = false;
            Invoke("Piar", Random.Range(5,15));
        }
    }

    public void Piar()
    {
        piar = true;
        sonido.clip = normal;
        sonido.Play();
    }

    public void Triste()
    {
     
        sonido.clip = triste;
        sonido.Play();
    }

    public void Ganar()
    {
        sonido.clip = ganar;
        sonido.Play();
    }
}
