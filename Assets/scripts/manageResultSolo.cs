using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class manageResultSolo : MonoBehaviour
{
    public GameObject[] power;
    private Vector3 point;
    private float Ptimer;
    private int inde;

    private float Dtimer;

    public GameObject P1;
    public GameObject P2;

    private int Newnum;

    private int Fnum = 1000;
    private int Snum = 0432;
    private int Tnum = 0358;
    private int Fonum = 0100;
    private int Finum = 0010;

    public Text[] textScore;

    private List<int> score = new List<int>();

    public void AddToList(int value)
    {
        score.Add(value);
    }

    void Start()
    {
        pelota.agranda = false;
        pelota.cambio = false;
        pelota.doble = false;
        pelota.velocidad = false;
        player.muerte = false;
        player2.muerte = false;
        PlayerSolo.muerte = false;

        Newnum = PlayerPrefs.GetInt("micoS") + PlayerPrefs.GetInt("segS")*10 + PlayerPrefs.GetInt("min1S")*100 + PlayerPrefs.GetInt("min2S")*1000;

        if (PlayerPrefs.GetInt("Primeros") != 0)
        {
            Fnum = PlayerPrefs.GetInt("PrimeroS");
            Snum = PlayerPrefs.GetInt("SegundoS");
            Tnum = PlayerPrefs.GetInt("TerceroS");
            Fonum = PlayerPrefs.GetInt("CuartoS");
            Finum = PlayerPrefs.GetInt("QuintoS");
        }

        player.muerte = false;
        player2.muerte = false;

        AddToList(Fnum);
        AddToList(Snum);
        AddToList(Tnum);
        AddToList(Fonum);
        AddToList(Finum);
        AddToList(Newnum);
    }

    void Update()
    {
        Camera.main.aspect = 1.8f;
        print(luces.lucesINT);

        if (Input.GetKeyDown(KeyCode.Return))
        {
            menu();
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
                GameObject Po3 = Instantiate(power[2], point, Quaternion.identity);
                Po3.name = "velocidad";
            }
            if (inde == 2)
            {
                GameObject Po4 = Instantiate(power[3], point, Quaternion.identity);
                Po4.name = "agranda";
            }
            if (inde == 3)
            {
                GameObject Po5 = Instantiate(power[4], point, Quaternion.identity);
                Po5.name = "cambio";
            }

            Ptimer = 0;
        }

        if (playerMenu.muerte)
        {
            Dtimer += Time.deltaTime;
            if (Dtimer >= 9)
            {

                GameObject R1 = Instantiate(P1, new Vector3(-5.46f, 0, -0.75f), Quaternion.identity);
                R1.name = "p1bot";
                GameObject R2 = Instantiate(P2, new Vector3(5.52f, 0, -0.75f), Quaternion.identity);
                R2.name = "p2bot";

                Dtimer = 0;
                playerMenu.muerte = false;
            }
        }

        for (int i = 0; i < score.Count; i++)
        {
            for (int j = i + 1; j < score.Count; j++)
            {
                if(score[j] > score[i])
                {
                    int temp = score[i];
                    score[i] = score[j];
                    score[j] = temp;
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            if(score[i].ToString().Length == 4)
            {
                textScore[i].text = score[i].ToString().Substring(0,1) + score[i].ToString().Substring(1,1) 
                            + " : " + score[i].ToString().Substring(2,1) + score[i].ToString().Substring(3,1);
            }
            else if (score[i].ToString().Length == 3)
            {
                textScore[i].text = "0" + score[i].ToString().Substring(0, 1)
                            + " : " + score[i].ToString().Substring(1, 1) + score[i].ToString().Substring(2, 1);
            }
            else if (score[i].ToString().Length == 2)
            {
                textScore[i].text = "0" + "0"
                            + " : " + score[i].ToString().Substring(0, 1) + score[i].ToString().Substring(1, 1);
            }

        }

    }

    public void menu()
    {
        player.muerte = false;
        player2.muerte = false;
        PlayerSolo.muerte = false;
        PlayerPrefs.SetInt("PrimeroS", score[0]);
        PlayerPrefs.SetInt("SegundoS", score[1]);
        PlayerPrefs.SetInt("TerceroS", score[2]);
        PlayerPrefs.SetInt("CuartoS", score[3]);
        PlayerPrefs.SetInt("QuintoS", score[4]);
        SceneManager.LoadScene("Menu");

        luces.lucesINT = 0;
    }

}
