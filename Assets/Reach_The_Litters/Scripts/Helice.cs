using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour
{
    //Declaramos el point effector (que generará la fuerza), una variable tiempo y otra de velocidad máxima
    PointEffector2D poi;
    Animator anim;
    public float tiempo;
    public float velMax;
    

    // Start is called before the first frame update
    void Start()
    {
        //Accedemos al point effector y lo ponemos falso de base
        poi = GetComponent<PointEffector2D>();

        poi.enabled = false;

        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creamos una corrutina, a la que llamaremos después para que cuando pase el "tiempo" deje de echar aire
    IEnumerator PararMotor()
    {
        //Devolvemos el tiempo que esta echando aire y volvemos el point effector a falso para que pare
        yield return new WaitForSeconds(tiempo);
        poi.enabled = false;
    }

    
    private void OnMouseDown()
    {
        poi.enabled = true;            //Aqui cuando pulsemos el ventilador activamos el point effector
        StartCoroutine(PararMotor());  //Llamamos a la corrutina para que cuando pase el tiempo pare

        anim.SetTrigger("pulsada");
        //Invoke("parada", 0.5f);
        //mientras la fuerza del point effector sea menor que la máxima, le vamos sumando 1 con cada pulsación, cuando llega a la max se para
        if (poi.forceMagnitude < velMax)   
        {
            poi.forceMagnitude = poi.forceMagnitude + 1;
        }
        
    }

    private void parada()
    {
        anim.SetBool("pulsada", false);
        
    }
}