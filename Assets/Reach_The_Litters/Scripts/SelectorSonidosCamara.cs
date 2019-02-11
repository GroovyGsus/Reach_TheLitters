using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorSonidosCamara : MonoBehaviour
{

    public AudioClip pulsarTicket;
    public AudioClip pulsarBoton;
    AudioSource audCam;

    // Start is called before the first frame update
    void Start()
    {
        audCam = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SonidoPulsarBoton()
    {
        audCam.clip = pulsarBoton;
        audCam.Play();
    }

    public void SonidoPulsarTicket()
    {
        audCam.clip = pulsarTicket;
        audCam.Play();
    }


}
