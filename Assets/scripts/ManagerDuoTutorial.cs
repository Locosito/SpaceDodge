using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManagerDuoTutorial : MonoBehaviour
{
    public GameObject[] lista1;
    private int numA;
    public GameObject[] objetos;
    private bool decision;
    public Text texto;
    public string[] indicaciones;
    private int numT;
    private float timerP;
    private bool listoT = false;

    public static int nextT;

    void Start()
    {
        numA = 0;
        numT = 0;
        decision = true;
        texto.text = indicaciones[0];
    }

    void Update()
    {
        print(luces.lucesINT);
        Camera.main.aspect = 1.8f;

        if (!decision)
        {
            objetos[1].SetActive(true);
        }

        if (nextT == 4)
        {
            numT += 1;
            nextT = 0;
        }

            switch (numT)
        {
            case 0:
                if (listoT)
                {
                    timerP += Time.deltaTime;
                }

                if (timerP >= 2)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;

            case 1:
                texto.text = indicaciones[1];
                objetos[2].SetActive(true);
                objetos[3].SetActive(true);
                
                break;

            case 2:
                timerP += Time.deltaTime;
                texto.text = indicaciones[2];
                if (timerP >= 3)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;

            case 3:
                timerP += Time.deltaTime;
                texto.text = indicaciones[3];
                objetos[2].SetActive(false);
                objetos[4].SetActive(true);
                if(timerP >= 5)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;

            case 4:
                texto.text = indicaciones[4];
                timerP += Time.deltaTime;
                if (timerP >= 5)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;
            case 5:
                texto.text = indicaciones[5];
                objetos[4].SetActive(false);
                objetos[5].SetActive(true);
                timerP += Time.deltaTime;
                if (timerP >= 4)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;

            case 6:
                texto.text = indicaciones[6];
                objetos[5].SetActive(false);
                objetos[6].SetActive(true);
                timerP += Time.deltaTime;
                if (timerP >= 5)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;
            case 7:
                texto.text = indicaciones[7];
                objetos[6].SetActive(false);
                timerP += Time.deltaTime;
                if (timerP >= 5)
                {
                    numT += 1;
                    timerP = 0;
                }

                break;
            case 8:
                texto.text = indicaciones[8];
                objetos[2].SetActive(true);
                player.escudo1 = true;
                player2.escudo2 = true;
                timerP += Time.deltaTime;
                if (timerP >= 4)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;

            case 9:
                texto.text = indicaciones[9];
                objetos[2].SetActive(false);
                player.escudo1 = false;
                player2.escudo2 = false;
                timerP += Time.deltaTime;
                if (timerP >= 5)
                {
                    numT += 1;
                    timerP = 0;
                }
                break;
            case 10:
                texto.text = indicaciones[10];
                timerP += Time.deltaTime;
                if (timerP >= 5)
                {
                    SceneManager.LoadScene("Duo");
                }

                break;
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            numA -= 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            numA += 1;
        }

        if (numA > 1)
        {
            numA = 0;
        }
        if (numA < 0)
        {
            numA = 1;
        }

        if (decision) {
            switch (numA)
            {
                case 0:

                    lista1[0].SetActive(true);
                    lista1[1].SetActive(false);

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        si();
                        listoT = true;
                    }

                    break;

                case 1:

                    lista1[0].SetActive(false);
                    lista1[1].SetActive(true);

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        no();
                    }

                    break;
            }
        }
    }

    void si()
    {
        objetos[0].transform.position = new Vector3(-1000, transform.position.y);
        decision = false;
    }

    void no()
    {
        SceneManager.LoadScene("Duo");
    }
}
