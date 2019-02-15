using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSonidosCamara : MonoBehaviour
{

    public AudioClip pulsarTicket;
    public AudioClip pulsarBoton;
    public AudioClip musicaMenu;
    public AudioSource audCam;

    public static SelectorSonidosCamara instancia;

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

        SelectorSonidosCamara.instancia.audCam = GetComponent<AudioSource>();
        SelectorSonidosCamara.instancia.audCam.clip = musicaMenu;
        SelectorSonidosCamara.instancia.audCam.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SonidoPulsarBoton()
    {
        
        SelectorSonidosCamara.instancia.audCam.clip = pulsarBoton;
        SelectorSonidosCamara.instancia.audCam.Play();
        
        Debug.Log("ha sonadoo");
    }

    public void SonidoPulsarTicket()
    {
        SelectorSonidosCamara.instancia.audCam.clip = pulsarTicket;
        SelectorSonidosCamara.instancia.audCam.Play();
    }
    

    
}
