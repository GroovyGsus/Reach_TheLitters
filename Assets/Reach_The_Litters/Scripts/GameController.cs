﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    //Cosas para desbloquear los niveles
    public Button[] BotonesM1;

    public int nextLvl = 0;

    void Start()
    {
        int lvlUnlock = PlayerPrefs.GetInt("lvlUnlock", 0);

        for (int i = 0; i < BotonesM1.Length; i++)
        {
            if (i > lvlUnlock)
            {
                BotonesM1[i].interactable = false;
            }
        }
    }

    public void PasarNivel()
    {
        if (nextLvl < 4)
        {
            nextLvl++;
            PlayerPrefs.SetInt("lvlUnlock", nextLvl);
        }

    }


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
