using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helice : MonoBehaviour
{

    PointEffector2D poi;
    public float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        poi = GetComponent<PointEffector2D>();

        poi.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            poi.enabled = true;
            StartCoroutine(PararMotor());
        }
    }

    IEnumerator PararMotor()
    {
        yield return new WaitForSeconds(tiempo);
        poi.enabled = false;
    }
}