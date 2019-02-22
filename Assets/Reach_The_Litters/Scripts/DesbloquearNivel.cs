using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DesbloquearNivel : MonoBehaviour
{

    public Button N1;
    public Button N2;
    public Button N3;
    public Button N4;

    public GameObject huevo;

    //int nivel;
    int mundo;

    // Start is called before the first frame update
    void Start()
    {
        N1.interactable = false;
        N2.interactable = false;
        N3.interactable = false;
        N4.interactable = false;

        //nivel = huevo.GetComponent<RecogerHuevo>().nivel;

        mundo = huevo.GetComponent<RecogerHuevo>().mundo;

    }

    // Update is called once per frame
    void Update()
    {

        
            PasaNivel();
        

        
    }

    public void PasaNivel()
    {
        if (GameController.nivelMax[mundo] > 0)
        {
            N1.interactable = true;

            if (GameController.nivelMax[mundo] > 1)
            {
                N2.interactable = true;

                if (GameController.nivelMax[mundo] > 2)
                {
                    N3.interactable = true;

                    if (GameController.nivelMax[mundo] > 3)
                    {
                        N4.interactable = true;
                    }
                }
            }
        }
    }
}
