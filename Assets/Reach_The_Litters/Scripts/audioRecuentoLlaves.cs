using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioRecuentoLlaves : MonoBehaviour
{ 
     AudioSource sonidoRecuentoLlaves;
//Hace sonar las llaves 
void Start()
    {
        sonidoRecuentoLlaves = GetComponent<AudioSource>();
    }

    public  void SuenaLlaves()
    {
      
            sonidoRecuentoLlaves.Play();
     
    }
}
