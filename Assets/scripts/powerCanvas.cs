using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class powerCanvas : MonoBehaviour
{
    public Image img;
    public Sprite[] pow;
    private int aa = 0;
    private bool crear = false;

    void Start()
    {
        img.color = new Color(255,255,255,aa);
    }

    void Update()
    {
        if (pelota.cambio)
        {          
            crear = true;
            img.sprite = pow[0];
        }
        if (pelota.agranda)
        {
            crear = true;
            img.sprite = pow[1];
        }
        if (pelota.doble)
        {
            crear = true;
            img.sprite = pow[2];
        }
        if (pelota.velocidad)
        {
            crear = true;
            img.sprite = pow[3];
        }

        if (crear)
        {  
            if(aa <= 255)
            {
                aa += 1;
                crear = false;
            }
        }
        if (!crear)
        {
            if (aa >= 0)
            {
                aa -= 5;
            }
        }
    }
}
