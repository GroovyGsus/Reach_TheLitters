using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesbloquearNivel : MonoBehaviour
{

    Button boton;
    public int nivel;
    public int mundo;
       
    // Start is called before the first frame update
    void Start()
    {
        //Sirve para bloquear y desbloquear el boton de los niveles si no están desbloqueados
        boton = GetComponent<Button>();
        boton.interactable = false;
        if (GameController.nivelMax[mundo] >= nivel)
        {
            boton.interactable = true;
        }
    }
    
}
