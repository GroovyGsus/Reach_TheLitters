﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    static public int llaves = 0;

    static public int[] nivelMax = new[] { 1, 0, 0 };

    public Animator panelSelector;
    public Animator panelTickets;
    public Animator cartelMundos;
    public Animator MenuPausa;
    public Animator PanelLlavesAnimator;
    Animator PanelLlavesNivelCompletado;
    int mundo = 1;

    GameObject botonPausa;
    GameObject panelLlaves;

    public Animator ticketM1;

    public AudioSource sonidoCogerLlave;

    private bool pausaDesactivada = true;

    //Cosas para desbloquear los niveles

    Scene escenaActual;

    public static GameController instancia;


    private void Awake()
    {

        if (instancia == null)
        {
            instancia = this;
        }

        else if (instancia != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }


    public void Start()
    {
        
       
        
    }
    public void Pausa()
    {
        MenuPausa.SetBool("Pausa", pausaDesactivada);

        if (pausaDesactivada)
        {
            Time.timeScale = 0;
            OcultaInterfaz();
        }

        else
        {
            Time.timeScale = 1;
            ActivaInterfaz();
        }
            

        pausaDesactivada = !pausaDesactivada;
        Debug.Log("Pausado!");
    }

    public void OcultaInterfaz ()
    {
        botonPausa.active = false;
        panelLlaves.active = false;
    }

    public void ActivaInterfaz ()
    {
        botonPausa.active = true;
        panelLlaves.active = true;
    }
    public void Reinicio()
    {
        llaves = 0;
        PanelLlavesNivelCompletado.SetInteger("llavesRecogidas", llaves);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    

    public void CargarSeleccionMundo()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("Seleccion_Mundo");
    }

    public void CargarSelecNivelesM1()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        Invoke("CargarNivelesM1", 0.5f);
    }

    public void CargarSelecNivelesM2()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        Invoke("CargarNivelesM2", 0.5f);
    }

    public void CargarSelecNivelesM3()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        Invoke("CargarNivelesM3", 0.5f);
    }

    public void CargarNivelesM1()
    {
        
        SceneManager.LoadScene("SelecNivelM1");
    }

    public void CargarNivelesM2()
    {

        SceneManager.LoadScene("SelecNivelM2");
    }

    public void CargarNivelesM3()
    {

        SceneManager.LoadScene("SelecNivelM3");
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

    public void CargarM2N1()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M2.N1");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM2N2()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M2.N2");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM2N3()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M2.N3");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM3N1()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M3.N1");
        Time.timeScale = 1;
        llaves = 0;
    }

    public void CargarM3N2()
    {
        SelectorMusicaFondo.instancia.suenaMusicaMenu = false;
        SceneManager.LoadScene("M3.N2");
        Time.timeScale = 1;
        llaves = 0;

    }

    public void CargarPantallaPrincipal()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("PantallaPrincipal");
    }

    public void CargarPantallaOpciones()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("PantallaOpciones");
    }

    public void CargarPantallaInicio()
    {
        Time.timeScale = 1;
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
        if (PanelLlavesAnimator != null)
        {
            PanelLlavesAnimator.SetInteger("Numllaves", llaves);
            PanelLlavesNivelCompletado.SetInteger("llavesRecogidas", llaves);
        }
        else {
            Debug.Log("PANEL LLAVES ES NULL");
        }

    }

    public void ReseteaAnimLlaves()
    {
        PanelLlavesNivelCompletado.SetTrigger("reinicia");
    }

    public void SonidoCogerLlave()
    {
        sonidoCogerLlave.Play();
        Debug.Log("ha sonao bro");
    }
    

    void Update ()
    {
        

        if (GameObject.Find("Panel_recuento_llaves") && PanelLlavesNivelCompletado == null)
        {
            Debug.Log("Encontrado Panel_recuento_llaves");
            PanelLlavesNivelCompletado = GameObject.Find("Panel_recuento_llaves").GetComponent<Animator>();
        }

        if (GameObject.Find("BotonPausa") && botonPausa == null)
        {
            Debug.Log("Encontrado BotonPausa");
            botonPausa = GameObject.Find("BotonPausa");
        }

        if (GameObject.Find("PanelLlaves") && panelLlaves == null)
        {
            Debug.Log("Encontrado PanelLlaves " );
            panelLlaves = GameObject.Find("PanelLlaves");
            PanelLlavesAnimator = panelLlaves.GetComponent<Animator>();
        }
        

        numerodeLlaves();
        Debug.Log(llaves);

    }
}
