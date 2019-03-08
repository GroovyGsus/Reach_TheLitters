using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActualizaLlaves : MonoBehaviour
{
    Text textollaves;
    // Start is called before the first frame update
    void Start()
    {
        textollaves = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textollaves.text = GameController.llavesTotales.ToString();
    }
}
