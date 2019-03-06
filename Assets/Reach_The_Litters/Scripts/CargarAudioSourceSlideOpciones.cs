using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarAudioSourceSlideOpciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Slider>().onValueChanged.AddListener(UpdateAudio);
    }

    public void UpdateAudio(float value)
    {
        GameObject.Find("MusicaFondo").GetComponent<AudioSource>().volume = value;
    }
}
