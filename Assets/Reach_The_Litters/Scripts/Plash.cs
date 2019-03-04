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
        //Cuando se pulsa sobre el delfín, se activa la animacion, se genera una pelota con medio segundo de retraso y se reproduce el sonido del delfin
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
