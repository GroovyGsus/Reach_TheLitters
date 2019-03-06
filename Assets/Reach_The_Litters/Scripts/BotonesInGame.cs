using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesInGame : MonoBehaviour
{

    GameController gc;

    public int nextSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.Find("GameController").GetComponent<GameController>();

        nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausa()
    {
        gc.Pausa();
    }

    public void Reinicio()
    {
        gc.Reinicio();
    }

    public void Ajustes()
    {
        gc.CargarPantallaOpciones();
    }

    public void CargarSelecMundo()
    {
        gc.CargarSeleccionMundo();
    }


    public void SiguienteNivel()
    {
        Debug.Log(SceneManager.sceneCount);
        if (SceneManager.sceneCountInBuildSettings > nextSceneIndex)
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(nextSceneIndex);
            gc.ReseteaAnimLlaves();
        }
    }
    
    


}
