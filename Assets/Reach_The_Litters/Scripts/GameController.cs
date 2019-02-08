using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    static public int llaves = 0;

    public bool[] nivelesM1;


    public Animator panelSelector;
    public Animator panelTickets;
    public Animator cartelMundos;
    int mundo = 1;

    public Animator ticketM1;

    public AudioSource sonidoCogerLlave;
    

    public void Pausa()
    {
        if (Time.timeScale == 1)
        {    //si la velocidad es 1
            Time.timeScale = 0;     //que la velocidad del juego sea 0
        }
        else if (Time.timeScale == 0)
        {   // si la velocidad es 0
            Time.timeScale = 1;     // que la velocidad del juego regrese a 1
        }
    }

    public void Reinicio()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void DesbloquearNivel(int nivel)
    {
        nivelesM1[nivel] = true;
    }

    public void CargarSeleccionMundo()
    {
        SceneManager.LoadScene("Seleccion_Mundo");
    }

    public void CargarSelecNivelesM1()
    {

        Invoke("CargarNivelesM1", 0.5f);
    }

    public void CargarNivelesM1()
    {
        SceneManager.LoadScene("SelecNivelM1");
    }

    public void CargarM1N1()
    {
        SceneManager.LoadScene("M1N1");
    }

    public void CargarM1N2()
    {
        SceneManager.LoadScene("M1N2");
    }

    public void CargarM1N3()
    {
        SceneManager.LoadScene("M1N3");
    }

    public void CargarM1N4()
    {
        SceneManager.LoadScene("M1N4");
    }

    public void CargarPantallaPrincipal()
    {
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void CargarPantallaOpciones()
    {
        SceneManager.LoadScene("PantallaOpciones");
    }

    public void CargarPantallaInicio()
    {
        SceneManager.LoadScene("PantallaInicio");
    }

    public void SiguienteMundo()
    {
        if (mundo <3)
        {
            mundo++;
            panelSelector.SetInteger("Mundo", mundo);
            panelTickets.SetInteger("Mundo", mundo);
            cartelMundos.SetInteger("Mundo", mundo);
        }
        
    }

    public void AnteriorMundo()
    {
        if (mundo >1)
        {
            mundo--;
            panelSelector.SetInteger("Mundo", mundo);
            panelTickets.SetInteger("Mundo", mundo);
            cartelMundos.SetInteger("Mundo", mundo);
        }
        
    }

    public void SonidoCogerLlave()
    {
        sonidoCogerLlave.Play();
        Debug.Log("ha sonao bro");
    }
}
