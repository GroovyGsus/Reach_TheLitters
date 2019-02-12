using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerHuevo : MonoBehaviour
{
    AudioSource sonido;


    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            sonido.Play();
        }
          
    }
}
