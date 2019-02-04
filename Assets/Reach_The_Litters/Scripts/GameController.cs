using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    static public int llaves = 0;

    public bool[] nivelesM1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DesbloquearNivel(int nivel)
    {
        nivelesM1[nivel] = true;
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene("Seleccion_Mundo");
    }

    public void CargarSelecNivelesM1()
    {
        SceneManager.LoadScene("SelecNivelM1");
    }
}
