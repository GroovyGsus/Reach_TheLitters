using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarObjetos : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.tag != "Huevo" && other.gameObject.tag !="Player")
        {
            Destroy(other.gameObject);
        }
    }
}
