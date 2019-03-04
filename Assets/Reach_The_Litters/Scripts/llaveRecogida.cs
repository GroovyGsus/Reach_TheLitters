using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class llaveRecogida : MonoBehaviour
{
    public GameObject gameController;

    private void Start()
    {

        gameController = GameObject.FindGameObjectWithTag("GameController");
    
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        //mostramos quien ha tocado el collider de tipo trigger
        Debug.Log(col.gameObject.name);


        //Cuando es tocado por el Huevo o el player, suena el sonido de recoger llaves, añade 1 a la variable llaves que está en el GameController y se destruye
        if (col.gameObject.tag == "Huevo" || col.gameObject.tag == "Player")

        {
            if(gameController != null)
            {
                gameController.GetComponent<GameController>().SonidoCogerLlave();
            }
            else
            {
                Debug.LogError("No encuentro el GameController por su tag");
            }
            

            GameController.llaves++;
            Debug.Log("EUREKA! Ya tengo "+ GameController.llaves );
            Destroy(gameObject);
        }
    }

   

}