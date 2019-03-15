using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesPrincipal : MonoBehaviour
{
    //Carga la pantalla de Inicio

    public void CargarPantallaInicio()
    {
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("PantallaInicio");
    }
}
