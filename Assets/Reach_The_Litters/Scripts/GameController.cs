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
        llaves = 0;
        PanelLlavesNivelCompletado.SetInteger("llavesRecogidas", llaves);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void DesbloquearNivel(int nivel)
    {
        nivelesM1[nivel] = true;
    }

    public void CargarSeleccionMundo()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("Seleccion_Mundo");
    }

    public void CargarSelecNivelesM1()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        Invoke("CargarNivelesM1", 0.5f);
    }

    public void CargarNivelesM1()
    {
        
        SceneManager.LoadScene("SelecNivelM1");
    }

    public void CargarM1N1()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M1N1");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM1N2()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M1N2");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM1N3()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M1N3");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM1N4()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M1N4");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarPantallaPrincipal()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void CargarPantallaOpciones()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("PantallaOpciones");
    }

    public void CargarPantallaInicio()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
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
        //Debug.Log(llaves);
    }
}
