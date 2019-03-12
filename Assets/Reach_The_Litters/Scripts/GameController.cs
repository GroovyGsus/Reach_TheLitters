using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    static public int llaves = 0;

    static public int llavesTotales = 0;

    static public int[] nivelMax = new[] { 1, 0, 0 };

    
    public Animator MenuPausa;
    public Animator PanelLlavesAnimator;
    
    public Animator PanelLlavesNivelCompletado;
    

    public GameObject botonPausa;
    public GameObject panelLlaves;

    public AudioSource sonidoCogerLlave;

    public bool pausa = false;

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
        llavesTotales = PlayerPrefs.GetInt("llaves_totales");
        nivelMax[0] = PlayerPrefs.GetInt("nivelMax0");
        nivelMax[1] = PlayerPrefs.GetInt("nivelMax1");
        nivelMax[2] = PlayerPrefs.GetInt("nivelMax2");
    }

    void OnEnable()
    {
      
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // called second
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
    

        if (PanelLlavesNivelCompletado == null)
        {
            Debug.Log("Encontrado Panel_recuento_llaves");
            GameObject go_tmp = GameObject.Find("Panel_recuento_llaves");
            if (go_tmp != null) {
                PanelLlavesNivelCompletado = go_tmp.GetComponent<Animator>();

            }
        }

        if (MenuPausa == null)
        {
            Debug.Log("Encontrado MenuPausa");
            GameObject go_tmp = GameObject.Find("MenuPausa");
            if (go_tmp != null)
            {
                MenuPausa = go_tmp.GetComponent<Animator>();

            }
        }

        if (botonPausa == null)
        {
            Debug.Log("Encontrado BotonPausa");
            botonPausa = GameObject.Find("BotonPausa");
        }

        if (panelLlaves == null)
        {
            Debug.Log("Encontrado PanelLlaves ");
            panelLlaves = GameObject.Find("PanelLlaves");
            if(panelLlaves != null) {
                PanelLlavesAnimator = panelLlaves.GetComponent<Animator>();
            }
            
        }
        pausa = false;
        numerodeLlaves();


    }

    public void Start()
    {
        //PlayerPrefs.DeleteAll();
        CompruebaMundosDesbloqueados();


    }
    public void Pausa()
    {
        pausa = !pausa;
        MenuPausa.SetBool("Pausa", pausa);

        if (pausa)
        {
            Time.timeScale = 0;
            OcultaInterfaz();
        }

        else
        {
            Time.timeScale = 1;
            ActivaInterfaz();
        }
            

     
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
        pausa = false;
        llaves = 0;
        PanelLlavesNivelCompletado.SetInteger("llavesRecogidas", llaves);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    

    public void CargarSeleccionMundo()
    {
        CompruebaMundosDesbloqueados();
        Time.timeScale = 1;
        SelectorMusicaFondo.instancia.suenaMusicaMenu = true;
        SceneManager.LoadScene("Seleccion_Mundo");
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
        

      

        numerodeLlaves();
        Debug.Log(llaves);

    }

    public void LlavesACero()
    {
        llaves = 0;
    }

    public void GuardarNivel(int nivel, int mundo) {
        int llavesNivel = PlayerPrefs.GetInt("llaves_" + nivel + "_" + mundo);
        if ( llavesNivel < llaves)
        {
            llavesTotales += llaves - llavesNivel;
            PlayerPrefs.SetInt("llaves_" + nivel + "_" + mundo, llaves);
            PlayerPrefs.SetInt("llaves_totales", llavesTotales);                                
          
        }


        nivelMax[mundo] = PlayerPrefs.GetInt("nivelMax"+mundo);
        if(nivelMax[mundo]< nivel)
        {
            PlayerPrefs.SetInt("nivelMax"+mundo,nivel);
            nivelMax[mundo] = nivel;
        }
       
        PlayerPrefs.Save();
    }

    public void CompruebaMundosDesbloqueados()
    {
        if(nivelMax[0] == 0)
        {
            nivelMax[0] = 1;
            PlayerPrefs.SetInt("nivelMax0", 1);
        }
        

        if (llavesTotales >= 8 && nivelMax[1] == 0)
        {
            nivelMax[1] = 1;
            PlayerPrefs.SetInt("nivelMax1",1);
        }

        if (llavesTotales >= 14 && nivelMax[2] == 0)
        {
            nivelMax[2] = 1;
            PlayerPrefs.SetInt("nivelMax2", 1);
        }
    }
    
    /*
    public void CargarMundo(int mundo, int totalNivelesMundo) {
        for (int i = 0; i < totalNivelesMundo; i++) {
            int desbloqueado = PlayerPrefs.GetInt("desbloqueado_mundo_" + mundo + "_nivel_" + i);
            
            // SI desbloqueado = 1 ==> El nivel está desbloqueado
            // Activar o descativar el boton del nivel

        }

    }*/
}
