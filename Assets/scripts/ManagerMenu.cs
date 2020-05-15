using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerMenu : MonoBehaviour
{
    public GameObject[] power;
    private Vector3 point;
    private float Ptimer;
    private int inde;

    public Material[] materiales;
    private float Ctimer;
    private float Dtimer;

    private bool move = false;
    public GameObject[] boton;
    public GameObject P1;
    public GameObject P2;

    public GameObject[] lista2;

    private bool part1;
    private int numA;

    public Transform[] puntos;

    void Start()
    {
        pelota.agranda = false;
        pelota.cambio = false;
        pelota.doble = false;
        pelota.velocidad = false;
        player.muerte = false;
        player2.muerte = false;
        PlayerSolo.muerte = false;

        numA = 0;
        part1 = true;
    }

    void Update()
    {
        //print(numA);
        //print(part1);
        //Camera.main.aspect = 1.8f;

        print(luces.lucesINT);
        if (!part1)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            numA -= 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            numA += 1;
        }

            if (numA > 2)
            {
                numA = 0;
            }
            if (numA < 0)
            {
                numA = 2;
            }
        }

        if (part1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                play();
                move = true;
                part1 = false;
                print("hola");
            }
        }

        if (!part1)
        {
            switch (numA)
            {
                case 0:

                    lista2[0].SetActive(true);
                    lista2[1].SetActive(false);
                    lista2[2].SetActive(false);

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        back();
                    }


                    break;

                case 1:
                    lista2[0].SetActive(false);
                    lista2[1].SetActive(true);
                    lista2[2].SetActive(false);

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        duo();
                    }

                    break;

                case 2:
                    lista2[0].SetActive(false);
                    lista2[1].SetActive(false);
                    lista2[2].SetActive(true);

                    if (Input.GetKeyDown(KeyCode.Return))
                    {
                        solo();
                    }

                    break;
            }
        }

        Ptimer += Time.deltaTime;

        if (Ptimer >= 15)
        {
            inde = Random.Range(0, 4);
            point = new Vector3(Random.Range(-4.4f, 4.09f), Random.Range(-4.15f, 4.03f), -0.71f);

            if (inde == 0)
            {
                GameObject Po1 = Instantiate(power[0], point, Quaternion.identity);
                Po1.name = "doble";
            }
            if (inde == 1)
            {
                GameObject Po3 = Instantiate(power[1], point, Quaternion.identity);
                Po3.name = "velocidad";
            }
            if (inde == 2)
            {
                GameObject Po4 = Instantiate(power[2], point, Quaternion.identity);
                Po4.name = "agranda";
            }
            if (inde == 3)
            {
                GameObject Po5 = Instantiate(power[3], point, Quaternion.identity);
                Po5.name = "cambio";
            }

            Ptimer = 0;
        }


        if (!move)
        {

                boton[0].transform.position = Vector3.MoveTowards(boton[0].transform.position, puntos[0].position, 700 * Time.deltaTime);

            boton[1].transform.position = Vector3.MoveTowards(boton[1].transform.position, puntos[8].position, 700 * Time.deltaTime);

            boton[2].transform.position = Vector3.MoveTowards(boton[2].transform.position, puntos[1].position, 700 * Time.deltaTime);

                boton[3].transform.position = Vector3.MoveTowards(boton[3].transform.position, puntos[2].position, 700 * Time.deltaTime);

                boton[4].transform.position = Vector3.MoveTowards(boton[4].transform.position, puntos[3].position, 700 * Time.deltaTime);

        }

        else
        {
            boton[0].transform.position = Vector3.MoveTowards(boton[0].transform.position, puntos[4].position, 700 * Time.deltaTime);

            boton[1].transform.position = Vector3.MoveTowards(boton[1].transform.position, puntos[9].position, 700 * Time.deltaTime);

            boton[2].transform.position = Vector3.MoveTowards(boton[2].transform.position, puntos[5].position, 700 * Time.deltaTime);

            boton[3].transform.position = Vector3.MoveTowards(boton[3].transform.position, puntos[6].position, 700 * Time.deltaTime);

            boton[4].transform.position = Vector3.MoveTowards(boton[4].transform.position, puntos[7].position, 700 * Time.deltaTime);
        }

        if (playerMenu.muerte)
        {
            Dtimer += Time.deltaTime;
            if(Dtimer >= 9)
            {
                
                GameObject R1 = Instantiate(P1, new Vector3(-5.46f, 0, -0.75f),Quaternion.identity);
                R1.name = "p1bot";
                GameObject R2 = Instantiate(P2, new Vector3(5.52f, 0, -0.75f), Quaternion.identity);
                R2.name = "p2bot";

                Dtimer = 0;
                playerMenu.muerte = false;
            }
        }


        
    }

    public void play()
    {
        move = true;
        part1 = false;
    }

    public void exit()
    {
        Application.Quit();
    }

    public void back()
    {
        move = false;
        part1 = true;
    }
    
    public void duo()
    {
        player.muerte = false;
        player2.muerte = false;
        PlayerSolo.muerte = false;
        SceneManager.LoadScene("DuoTutorial");
        luces.lucesINT = 1;
    }

    public void solo()
    {
        player.muerte = false;
        player2.muerte = false;
        PlayerSolo.muerte = false;
        SceneManager.LoadScene("SoloTutorial");
        luces.lucesINT = 1;
    }
}
