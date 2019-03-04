using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {   //Esto sirve para que todos los objetos que colisionan con el area de juego, que no sean ni el Huevo ni el Player, se destruyan
       if (other.gameObject.tag != "Huevo" && other.gameObject.tag !="Player")
        {
            Destroy(other.gameObject);
        }
    }
}
