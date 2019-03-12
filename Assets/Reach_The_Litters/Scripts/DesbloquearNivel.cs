using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesbloquearNivel : MonoBehaviour
{

    Button boton;
    public int nivel;
    public int mundo;
    Animator anim;
       
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("desbloquear", false);

        //Sirve para bloquear y desbloquear el boton de los niveles si no están desbloqueados
        boton = GetComponent<Button>();
        boton.interactable = false;
        Debug.Log(transform.name + " " + mundo + ":" + GameController.nivelMax[mundo]);
        if (GameController.nivelMax[mundo] >= nivel)
        {
            boton.interactable = true;
            anim.SetBool("desbloquear", true);
        }
    }
    
}
