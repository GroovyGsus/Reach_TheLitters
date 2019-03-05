using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SelectorMundos : MonoBehaviour
{

    int mundo = 1;

    public Animator panelSelector;
    public Animator panelTickets;
    public Animator cartelMundos;

    void Start()
    {

        if (panelSelector == null)
        {
            GameObject go_tmp = GameObject.Find("Panel_Selector");
            if (go_tmp != null)
            {
                panelSelector = go_tmp.GetComponent<Animator>();
            }
        }

        if (panelTickets == null)
        {
            GameObject go_tmp = GameObject.Find("Panel_Tickets");
            if (go_tmp != null)
            {
                panelTickets = go_tmp.GetComponent<Animator>();
            }
        }

        if (cartelMundos == null)
        {
            GameObject go_tmp = GameObject.Find("Cartel");
            if (go_tmp != null)
            {
                cartelMundos = go_tmp.GetComponent<Animator>();
            }
        }
    }


    //Pone el tiempo a uno, gestiona la musica y invoca con medio segundo de delay a cargar la seleccion de nivel del respectivo mundo

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


    //Carga la seleccion de niveles del respectivo mundo

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


    //Se mueve entre los diferentes mundos

    public void SiguienteMundo()
    {
        if (mundo < 3)
        {
            mundo++;
            panelSelector.SetInteger("Mundo", mundo);
            panelTickets.SetInteger("Mundo", mundo);
            cartelMundos.SetInteger("Mundo", mundo);
        }

    }

    public void AnteriorMundo()
    {
        if (mundo > 1)
        {
            mundo--;
            panelSelector.SetInteger("Mundo", mundo);
            panelTickets.SetInteger("Mundo", mundo);
            cartelMundos.SetInteger("Mundo", mundo);
        }

    }

    //Carga la pantalla de inicio, pone el tiempo a 1 y gestiona la musica

    public void CargarPantallaInicio()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("PantallaInicio");
    }
}
