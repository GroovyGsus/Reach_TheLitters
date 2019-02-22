using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecogerHuevo : MonoBehaviour
{
    AudioSource sonido;
    GameObject NivelCompletado;
    Animator anim;
    public GameObject gameController;
   

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
            gameController.GetComponent<GameController>().ReseteaAnimLlaves();
            Destroy(gameObject);
        }
    } 
}
