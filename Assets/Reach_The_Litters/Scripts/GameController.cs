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
    public Animator MenuPausa;
    public Animator PanelLlaves;
    public Animator PanelLlavesNivelCompletado;
    int mundo = 1;

    public Animator ticketM1;

    public AudioSource sonidoCogerLlave;

    


    private bool pausaDesactivada = true;


    public void Pausa()
    {
        MenuPausa.SetBool("Pausa", pausaDesactivada);

        if (pausaDesactivada)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;

        pausaDesactivada = !pausaDesactivada;
        Debug.Log("Pausado!");
    }

    public void Reinicio()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
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

    public void numerodeLlaves()
    {
        if(PanelLlaves!= null) { 
        PanelLlaves.SetInteger("Numllaves", llaves);
        PanelLlavesNivelCompletado.SetInteger("llavesRecogidas", llaves);
        }

    }

    public void SonidoCogerLlave()
    {
        sonidoCogerLlave.Play();
        Debug.Log("ha sonao bro");
    }
    

    void Update ()
    {
        numerodeLlaves();
        Debug.Log(llaves);
    }
}
