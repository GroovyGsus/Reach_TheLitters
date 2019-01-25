using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RompeCuerda : MonoBehaviour
{

    HingeJoint2D jointCuerda;
    LineRenderer lr;
    bool conectado = true; 

    // Start is called before the first frame update
    void Start()
    {
        jointCuerda = GetComponent<HingeJoint2D>();
        lr = GetComponent<LineRenderer>();
        lr.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (conectado)
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, jointCuerda.connectedBody.transform.position);
        }
       
       
    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Mouse" && Input.GetMouseButton(0))
        {
            conectado = false; 
            //gameObject.GetComponent<HingeJoint2D>();
            Destroy(jointCuerda);
            Destroy(lr);
        }
    }
}
