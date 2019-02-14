using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSonidosCamara : MonoBehaviour
{

    public AudioClip pulsarTicket;
    public AudioClip pulsarBoton;
    public AudioClip musicaMenu;
    AudioSource audCam;

    // Start is called before the first frame update
    void Start()
    {
        audCam = GetComponent<AudioSource>();

        audCam.clip = musicaMenu;
        audCam.Play();
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SonidoPulsarBoton()
    {
        audCam.clip = pulsarBoton;
        audCam.Play();
        Destroy(gameObject, audCam.clip.length);
    }

    public void SonidoPulsarTicket()
    {
        audCam.clip = pulsarTicket;
        audCam.Play();
    }
    

    
}
