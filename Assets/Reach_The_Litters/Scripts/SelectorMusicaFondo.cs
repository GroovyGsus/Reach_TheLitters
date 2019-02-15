using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectorMusicaFondo : MonoBehaviour
{

    public static SelectorMusicaFondo instancia;

    public AudioSource audCam;

    public AudioClip musicaMenu;

    public AudioClip musicaInGameM1;

    public bool  suenaMusicaMenu= true;

    Scene escenaActual;


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

    // Start is called before the first frame update
    void Start()
    {
        SelectorMusicaFondo.instancia.audCam = GetComponent<AudioSource>();
        escenaActual = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
       
        if(suenaMusicaMenu && SelectorMusicaFondo.instancia.audCam.clip != musicaMenu)
        {
            MusicaFondoMenus();
        }

        if (!suenaMusicaMenu && SelectorMusicaFondo.instancia.audCam.clip != musicaInGameM1)
        {
            MusicaFondoInGame();
        }

    }

    public void MusicaFondoMenus()
    {
        if(SelectorMusicaFondo.instancia.audCam.clip != musicaMenu && !SelectorMusicaFondo.instancia.audCam.isPlaying)
        {
            SelectorMusicaFondo.instancia.audCam.clip = musicaMenu;
            SelectorMusicaFondo.instancia.audCam.Play();
        }
       
    }

    public void MusicaFondoInGame()
    {
        if (SelectorMusicaFondo.instancia.audCam.clip != musicaInGameM1 && !SelectorMusicaFondo.instancia.audCam.isPlaying)
        {
            SelectorMusicaFondo.instancia.audCam.clip = musicaInGameM1;
            SelectorMusicaFondo.instancia.audCam.Play();
        }
    }
}
