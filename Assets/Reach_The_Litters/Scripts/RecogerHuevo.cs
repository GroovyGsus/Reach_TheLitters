using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecogerHuevo : MonoBehaviour
{
    AudioSource sonido;
    public int nivel = 1;
    public int mundo = 0;
    GameObject NivelCompletado;
    Animator anim;

    GameObject gameControl;

    void Start()
    {
        sonido = GetComponent<AudioSource>();

        NivelCompletado = GameObject.Find("panel_NivelCompletado");
        gameControl = GameObject.Find("GameController");
        if (NivelCompletado == null)
        {
            Debug.LogError("Hace falta tener el objeto Panel_NivelCompletado en la escena", gameObject);
        }
        else
        {
            anim = NivelCompletado.GetComponent<Animator>();
        }
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        //Cuando el Huevo colisiona con el Player, se activa la animacion de nivel completado, se pausa el juego, y suena el sonido de Maddy feliz. Además de gestionar los niveles del Game Controller, resetear la animacion de llaves de nivel completado y destruir el objeto

        if (other.gameObject.tag == "Player")
        {

            GameObject.Find("Maddy").GetComponent<SonidoMady>().Ganar();
            anim.SetTrigger("activar");
            Time.timeScale = 0;
            sonido.Play();

            Debug.Log("nivel "+ nivel + "mundo " + mundo);


            gameControl.GetComponent<GameController>().GuardarNivel(nivel, mundo);

            if(GameController.nivelMax[mundo] < nivel)
            {
                GameController.nivelMax[mundo] = nivel;
            }
            
            gameControl.GetComponent<GameController>().ReseteaAnimLlaves();
            gameControl.GetComponent<GameController>().OcultaInterfaz();
            Destroy(gameObject);
        }
          
    }
}
