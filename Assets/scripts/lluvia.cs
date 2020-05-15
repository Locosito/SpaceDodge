using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lluvia : MonoBehaviour
{
    public GameObject p1;
    public GameObject p2;
    public static bool active;
    private int numS;
    private Transform point;
    public GameObject[] asteroid;
    public GameObject[] señal;
    public static bool mira;
    private float tiempo1;
    private float tiempo2;
    private bool alerta1;
    private bool alerta2;


    void Start()
    {
        tiempo1 = 0;
        tiempo2 = 0;
        active = false;
        alerta1 = false;
        alerta2 = false;
        mira = true;
    }

    void Update()
    {
        //print(numS);
        if (active)
        {
            if (manager.revertR)
            {
                numS = 0;
            }

            if (manager.revertL)
            {
                numS = 1;
            }

            if (!manager.revertL && !manager.revertR && !alerta1 && !alerta2)
            {
                numS = Random.Range(0, 2);
            }
            if(numS == 1)
            {
                tiempo1 += Time.deltaTime;
                if (mira)
                {
                    p1.transform.position = new Vector3(p1.transform.position.x, Random.Range(-4.3f, 4.3f), p1.transform.position.z);
                    alerta1 = true;
                    mira = false;
                }

                if (alerta1)
                {
                    señal[0].SetActive(true);
                    tiempo1 += Time.deltaTime;
                }

                if(tiempo1 >= 2)
                {
                    alerta1 = false;
                    señal[0].SetActive(false);
                    GameObject AR = Instantiate(asteroid[0], new Vector3(p1.transform.position.x,p1.transform.position.y,p1.transform.position.z), Quaternion.identity);
                    AR.name = "asteroidR";
                    active = false;
                    tiempo1 = 0;
                }
                
            }
            if (numS == 0)
            {
                tiempo2 += Time.deltaTime;
                if (mira)
                {
                    p2.transform.position = new Vector3(p2.transform.position.x, Random.Range(-4.3f, 4.3f), p2.transform.position.z);
                    alerta2 = true;
                    mira = false;
                }

                if (alerta2)
                {
                    señal[1].SetActive(true);
                    tiempo2 += Time.deltaTime;
                }
                    if (tiempo2 >= 2)
                {
                    alerta2 = false;
                    señal[1].SetActive(false);
                    GameObject AL = Instantiate(asteroid[1], new Vector3(p2.transform.position.x, p2.transform.position.y, p2.transform.position.z), Quaternion.identity);
                    AL.name = "asteroidL";
                    active = false;
                    tiempo2 = 0;
                }
            }
        }


    }
}
