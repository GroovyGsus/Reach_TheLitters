using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llaveRecogida : MonoBehaviour
{
    

   

    void OnTriggerEnter2D(Collider2D col)
    {
        //mostramos quien ha tocado el collider de tipo trigger
        Debug.Log(col.gameObject.name);

        if (col.gameObject.tag == "Huevo" || col.gameObject.tag == "Player")

        {
            GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
            gameController.GetComponent<GameController>().SonidoCogerLlave();

            GameController.llaves++;
            Debug.Log("EUREKA! Ya tengo "+ GameController.llaves );
            Destroy(gameObject);
        }
    }

   

}