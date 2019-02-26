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
        boton = GetComponent<Button>();
        boton.interactable = false;
        if (GameController.nivelMax[mundo] >= nivel)
        {
            boton.interactable = true;
        }
    }
    
}
