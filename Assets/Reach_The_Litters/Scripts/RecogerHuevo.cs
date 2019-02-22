using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecogerHuevo : MonoBehaviour
{
    AudioSource sonido;
    GameObject NivelCompletado;
    Animator anim;
<<<<<<< HEAD
    public GameObject gameController;
   
=======

    public GameObject gameControl;
>>>>>>> 3d72eeb491e631a6c9191bce9f0f85869da18c97

    void Start()
    {
        sonido = GetComponent<AudioSource>();

        gameController = GameObject.FindGameObjectWithTag("GameController");

        NivelCompletado = GameObject.Find("panel_NivelCompletado");
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
        if (other.gameObject.tag == "Player")
        {

            anim.SetTrigger("activar");
            Time.timeScale = 0;
            sonido.Play();
<<<<<<< HEAD
            gameController.GetComponent<GameController>().ReseteaAnimLlaves();
=======

            gameControl.GetComponent<GameController>().PasarNivel();

>>>>>>> 3d72eeb491e631a6c9191bce9f0f85869da18c97
            Destroy(gameObject);
        }
    } 
}
