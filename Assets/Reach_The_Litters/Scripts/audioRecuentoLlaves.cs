using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioRecuentoLlaves : MonoBehaviour
{ 
     AudioSource sonidoRecuentoLlaves;
// Start is called before the first frame update
void Start()
    {
        sonidoRecuentoLlaves = GetComponent<AudioSource>();
    }

    public  void SuenaLlaves()
    {
      
            sonidoRecuentoLlaves.Play();
     
    }
}
