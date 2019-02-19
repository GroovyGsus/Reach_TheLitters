using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plash : MonoBehaviour
{

    public GameObject pelota;
    public Animator cuerpo;
    public Animator cola;
    AudioSource sonido;
    

    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        
        cuerpo.SetTrigger("cuerpear");
        cola.SetTrigger("colear");
        Invoke("generaPelota", 0.5f);
        sonido.Play();
    }

    void generaPelota()
    {
        Instantiate(pelota, transform.position, pelota.transform.rotation);
    }
}
