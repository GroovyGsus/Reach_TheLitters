using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecogerHuevo : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
          
    }
}
