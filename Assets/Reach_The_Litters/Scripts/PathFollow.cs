using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{
    // Start is called before the first frame update
    
        //Creamos float publico para cambiar la velocidad desde Unity
    public float velocidad;
    //Float para definir los pasos entre punto y punto en el Update
    float step;
    //Array con para meter los puntos del recorrido desde Unity
   public Transform[] targets;
    Vector3 target;
    int posicionTarget;
   Vector2 position;
    public bool pinchado = false;
    bool adelante = true;

    void Start()
    {
        posicionTarget = 0;
        //Cogemos la posicion de Tuit
        position = gameObject.transform.position;
        target = targets[posicionTarget].position;

    }

    // Update is called once per frame
    void Update()
    {
        //Definimos la velocidad segun la velocidad de los frames del ordenador
        step = velocidad * Time.deltaTime;

        //Si no se ha pinchado a Tuit, no se ejecuta
        if (pinchado)
        {
            //Cuando se haya pinchado, se movera hasta el primer target de la lista
            transform.position = Vector2.MoveTowards(transform.position, target, step);

            //Cuando la posicion de Tuit sea la misma que la del primer target, se suma uno a la lista y va hacia el siguiente
            if (transform.position == target)
            {
                if (adelante)
                {
                    posicionTarget++;
                }
                else
                {
                    posicionTarget--;
                }

                //Cuando la posicion sea mayor o igual que los numeros de la lista y esta yendo hacia adelante, se empezará a restar 1 en la lista e irá hacia atrás
                if(posicionTarget >= targets.Length && adelante)
                {
                    posicionTarget--;
                    adelante = false;
                }

                //Si no va hacia adelante y el numero de la lista en la que está es menor que 0, vuelve a ir hacia adelante
                if(!adelante && posicionTarget < 0)
                {
                    adelante = true;
                    posicionTarget = 0;
                }
                target = targets[posicionTarget].position;
            }
        }
            
    }

    //Cuando se pincha a Tuit, pinchado pasa a ser true
    private void OnMouseDown()
    {
        pinchado = true;
    }

}
