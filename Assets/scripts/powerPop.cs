using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class powerPop : MonoBehaviour
{

    public static bool dobleV;
    public static bool velocidadV;
    public static bool agrandaV;
    public static bool cambioV;

    public GameObject[] poder;
    private float Atimer;

    void Start()
    {
        poder[0].transform.position = new Vector3(0, 0, 0);
        poder[1].transform.position = new Vector3(0, 0, 0);
        poder[2].transform.position = new Vector3(0, 0, 0);
        poder[3].transform.position = new Vector3(0, 0, 0);
    }


    void Update()
    {
        ///////////////////////////////////////////////////////////////////////
        if (dobleV)
        {
            //poder[0].SetActive(true);
            if (poder[0].transform.localScale.x < 6)
            {
                poder[0].transform.localScale = new Vector3(poder[0].transform.localScale.x + 10 * Time.deltaTime, poder[0].transform.localScale.y + 10 * Time.deltaTime
                    , poder[0].transform.localScale.z + 10 * Time.deltaTime);

                poder[0].GetComponent<Image>().color = new Vector4(poder[0].GetComponent<Image>().color.r,
                    poder[0].GetComponent<Image>().color.g, poder[0].GetComponent<Image>().color.b, poder[0].GetComponent<Image>().color.a + 5 * Time.deltaTime);
                //print("Agrandar");
            }
            if(poder[0].transform.localScale.x >= 6)
            {

                dobleV = false;
                //print("Parar Agrandar");
            }
        }

        if (!dobleV)
        {
            if (poder[0].transform.localScale.x > 3f)
            {
                poder[0].transform.localScale = new Vector3(poder[0].transform.localScale.x - 3 * Time.deltaTime, poder[0].transform.localScale.y - 3 * Time.deltaTime
                    , poder[0].transform.localScale.z - 3 * Time.deltaTime);

                if (poder[0].GetComponent<Image>().color.a >= 0)
                {
                    poder[0].GetComponent<Image>().color = new Vector4(poder[0].GetComponent<Image>().color.r,
                    poder[0].GetComponent<Image>().color.g, poder[0].GetComponent<Image>().color.b, poder[0].GetComponent<Image>().color.a - 20 * Time.deltaTime);
                }
                //print("Encoger");
            }
        }

        ////////////////////////////////////////////////////////////////////////////

        if (velocidadV)
        {
            //poder[1].SetActive(true);
            if (poder[1].transform.localScale.x < 7)
            {
                poder[1].transform.localScale = new Vector3(poder[1].transform.localScale.x + 10 * Time.deltaTime, poder[1].transform.localScale.y + 10 * Time.deltaTime
                    , poder[1].transform.localScale.z + 10 * Time.deltaTime);

                poder[1].GetComponent<Image>().color = new Vector4(poder[1].GetComponent<Image>().color.r,
                    poder[1].GetComponent<Image>().color.g, poder[1].GetComponent<Image>().color.b, poder[1].GetComponent<Image>().color.a + 5 * Time.deltaTime);
                //print("Agrandar");
            }
            if (poder[1].transform.localScale.x >= 7)
            {

                    velocidadV = false;
                //print("Parar Agrandar");
            }
        }

        if (!velocidadV)
        {
            if (poder[1].transform.localScale.x >= 4)
            {
                poder[1].transform.localScale = new Vector3(poder[1].transform.localScale.x - 3 * Time.deltaTime, poder[1].transform.localScale.y - 3 * Time.deltaTime
                    , poder[1].transform.localScale.z - 3 * Time.deltaTime);

                if (poder[1].GetComponent<Image>().color.a >= 0)
                {
                    poder[1].GetComponent<Image>().color = new Vector4(poder[1].GetComponent<Image>().color.r,
                    poder[1].GetComponent<Image>().color.g, poder[1].GetComponent<Image>().color.b, poder[1].GetComponent<Image>().color.a - 20 * Time.deltaTime);
                }
                //print("Encoger");
            }
        }

        //////////////////////////////////////////////////////////////////////////////

        if (agrandaV)
        {
            //poder[2].SetActive(true);
            if (poder[2].transform.localScale.x < 10)
            {
                poder[2].transform.localScale = new Vector3(poder[2].transform.localScale.x + 10 * Time.deltaTime, poder[2].transform.localScale.y + 10 * Time.deltaTime
                    , poder[2].transform.localScale.z + 10 * Time.deltaTime);

                poder[2].GetComponent<Image>().color = new Vector4(poder[2].GetComponent<Image>().color.r,
                    poder[2].GetComponent<Image>().color.g, poder[2].GetComponent<Image>().color.b, poder[2].GetComponent<Image>().color.a + 5 * Time.deltaTime);
                //print("Agrandar");
            }
            if (poder[2].transform.localScale.x >= 10)
            {

                    agrandaV = false;

                //print("Parar Agrandar");
            }
        }

        if (!agrandaV)
        {
            if (poder[2].transform.localScale.x >= 7)
            {
                poder[2].transform.localScale = new Vector3(poder[2].transform.localScale.x - 3 * Time.deltaTime, poder[2].transform.localScale.y - 3 * Time.deltaTime
                    , poder[2].transform.localScale.z - 3 * Time.deltaTime);

                if (poder[2].GetComponent<Image>().color.a >= 0)
                {
                    poder[2].GetComponent<Image>().color = new Vector4(poder[2].GetComponent<Image>().color.r,
                        poder[2].GetComponent<Image>().color.g, poder[2].GetComponent<Image>().color.b, poder[2].GetComponent<Image>().color.a - 20 * Time.deltaTime);
                }
                //print("Encoger");
            }
        }

        //////////////////////////////////////////////////////////////////////////////

        if (cambioV)
        {
            //poder[3].SetActive(true);
            if (poder[3].transform.localScale.x < 5)
            {
                poder[3].transform.localScale = new Vector3(poder[3].transform.localScale.x + 10 * Time.deltaTime, poder[3].transform.localScale.y + 10 * Time.deltaTime
                    , poder[3].transform.localScale.z + 10 * Time.deltaTime);

                poder[3].GetComponent<Image>().color = new Vector4(poder[3].GetComponent<Image>().color.r,
                    poder[3].GetComponent<Image>().color.g, poder[3].GetComponent<Image>().color.b, poder[3].GetComponent<Image>().color.a + 5 * Time.deltaTime);
                //print("Agrandar");
            }
            if (poder[3].transform.localScale.x >= 5)
            {
                    cambioV = false;
                //print("Parar Agrandar");
            }
        }

        if (!cambioV)
        {
            if (poder[3].transform.localScale.x >= 2)
            {
                poder[3].transform.localScale = new Vector3(poder[3].transform.localScale.x - 3 * Time.deltaTime, poder[3].transform.localScale.y - 3 * Time.deltaTime
                    , poder[3].transform.localScale.z - 3 * Time.deltaTime);

                if (poder[3].GetComponent<Image>().color.a >= 0)
                {
                    poder[3].GetComponent<Image>().color = new Vector4(poder[3].GetComponent<Image>().color.r,
                    poder[3].GetComponent<Image>().color.g, poder[3].GetComponent<Image>().color.b, poder[3].GetComponent<Image>().color.a - 20 * Time.deltaTime);
                }
                //print("Encoger");
            }
        }

        //////////////////////////////////////////////////////////////////////////////
    }
}
