using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSonidosCamara : MonoBehaviour
{

    public AudioClip pulsarTicket;
    public AudioClip pulsarBoton;
    
    public AudioSource audCamSon;

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

        SelectorSonidosCamara.instancia.audCamSon = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SonidoPulsarBoton()
    {
        
        SelectorSonidosCamara.instancia.audCamSon.clip = pulsarBoton;
        SelectorSonidosCamara.instancia.audCamSon.Play();
        
        Debug.Log("ha sonadoo");
    }

    public void SonidoPulsarTicket()
    {
        SelectorSonidosCamara.instancia.audCamSon.clip = pulsarTicket;
        SelectorSonidosCamara.instancia.audCamSon.Play();
    }
    

    
}
