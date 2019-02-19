using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelFallido : MonoBehaviour

{



    GameObject panelNivelFallido;
    SonidoMady scriptSonido;
    Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        panelNivelFallido = GameObject.Find("Panel_nivel_fallido");
        scriptSonido =  GameObject.Find("Maddy").GetComponent<SonidoMady>();
        if(panelNivelFallido == null)
        {
            Debug.LogError("Hace falta tener el objeto Panel_nivel_fallido en la escena", gameObject);
        }
        else
        {
            anim = panelNivelFallido.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Area_Juego")
        {
            anim.SetTrigger("activar");
            scriptSonido.Triste();
            Time.timeScale = 0;
           
        }

    }



}

