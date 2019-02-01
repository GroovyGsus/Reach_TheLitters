using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ControlDeJuego : MonoBehaviour
{
    bool pulsas = false;
    // Start is called before the first frame update
    public void SiPulsas()
    {
        pulsas = !pulsas;
        if (pulsas == true)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
    public void Reinicio()
    {
        SceneManager.LoadScene(0);
    }

}
