using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    static public int llaves = 0;

    public bool[] nivelesM1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DesbloquearNivel(int nivel)
    {
        nivelesM1[nivel] = true;
    }
}
