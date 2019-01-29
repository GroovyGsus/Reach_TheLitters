using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plash : MonoBehaviour
{

    public GameObject pelota;
    public Animator cuerpo;
    public Animator cola;

    // Start is called before the first frame update
    void Start()
    {
        
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
    }

    void generaPelota()
    {
        Instantiate(pelota, transform.position, pelota.transform.rotation);
    }
}
