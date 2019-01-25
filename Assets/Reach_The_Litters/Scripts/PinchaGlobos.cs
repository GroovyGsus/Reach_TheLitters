using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinchaGlobos : MonoBehaviour


{
    public Animator anim;
    public Rigidbody2D rbGlobo;

    // Start is called before the first frame update
    void Start()
    {
        rbGlobo = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
       // rbGlobo.isKinematic = true;
       // rbGlobo.velocity = Vector2.zero;
        anim.SetTrigger("Pinchar");
        Destroy(gameObject,1f);

    }
}
