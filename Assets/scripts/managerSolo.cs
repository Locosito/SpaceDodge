using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class managerSolo : MonoBehaviour
{
    public GameObject[] power;
    private Vector3 point;
    private float Ptimer;
    private int inde;

    public GameObject[] numeros;

    private int microS = 0;
    private int segundos = 0;
    private int min1 = 0;
    private int min2 = 0;
    private float timer = 0;


    private bool changeM = true;
    private bool changeS = true;
    private bool changeM1 = true;
    private bool changeM2 = true;
    private bool changeScore = true;


    public Transform[] puntos;
    public Transform[] points;



    public GameObject GameOver;

    public static int vidas = 3;
    private float timeDeath = 0;
    public GameObject nave;

    public GameObject[] lifes;
    

    void Start()
    {
        vidas = 3;   
    }

    void Update()
    {
        Camera.main.aspect = 1.8f;
        print(luces.lucesINT);

        //print(microS);
        if (!PlayerSolo.muerte)
        {
            timer += Time.deltaTime;

            if (timer >= 1)
            {
                microS++;
                timer = 0;
                changeM = true;
            }

            if (microS >= 10)
            {
                segundos++;
                microS = 0;
                changeS = true;
            }
            if (segundos >= 6)
            {
                min1++;
                segundos = 0;
                changeM1 = true;
            }
            if (min1 >= 10)
            {
                min2++;
                min1 = 0;
                changeM2 = true;
            }

            if (changeM)
            {
                switch (microS)
                {
                    case 0:
                        Destroy(GameObject.Find("MS9"));
                        GameObject mico0 = Instantiate(numeros[0], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico0.transform.localScale /= 2;
                        mico0.name = "MS0";
                        changeM = false;
                        break;
                    case 1:
                        Destroy(GameObject.Find("MS0"));
                        GameObject mico1 = Instantiate(numeros[1], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico1.transform.localScale /= 2;
                        mico1.name = "MS1";
                        changeM = false;
                        break;
                    case 2:
                        Destroy(GameObject.Find("MS1"));
                        GameObject mico2 = Instantiate(numeros[2], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico2.transform.localScale /= 2;
                        mico2.name = "MS2";
                        changeM = false;
                        break;
                    case 3:
                        Destroy(GameObject.Find("MS2"));
                        GameObject mico3 = Instantiate(numeros[3], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico3.transform.localScale /= 2;
                        mico3.name = "MS3";
                        changeM = false;
                        break;
                    case 4:
                        Destroy(GameObject.Find("MS3"));
                        GameObject mico4 = Instantiate(numeros[4], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico4.transform.localScale /= 2;
                        mico4.name = "MS4";
                        changeM = false;
                        break;
                    case 5:
                        Destroy(GameObject.Find("MS4"));
                        GameObject mico5 = Instantiate(numeros[5], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico5.transform.localScale /= 2;
                        mico5.name = "MS5";
                        changeM = false;
                        break;
                    case 6:
                        Destroy(GameObject.Find("MS5"));
                        GameObject mico6 = Instantiate(numeros[6], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico6.transform.localScale /= 2;
                        mico6.name = "MS6";
                        changeM = false;
                        break;
                    case 7:
                        Destroy(GameObject.Find("MS6"));
                        GameObject mico7 = Instantiate(numeros[7], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico7.transform.localScale /= 2;
                        mico7.name = "MS7";
                        changeM = false;
                        break;
                    case 8:
                        Destroy(GameObject.Find("MS7"));
                        GameObject mico8 = Instantiate(numeros[8], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico8.transform.localScale /= 2;
                        mico8.name = "MS8";
                        changeM = false;
                        break;
                    case 9:
                        Destroy(GameObject.Find("MS8"));
                        GameObject mico9 = Instantiate(numeros[9], puntos[3].position, new Quaternion(0, 180, 0, 0));
                        mico9.transform.localScale /= 2;
                        mico9.name = "MS9";
                        changeM = false;
                        break;

                }
            }

            if (changeS)
            {
                switch (segundos)
                {
                    case 0:
                        Destroy(GameObject.Find("S5"));
                        GameObject seg0 = Instantiate(numeros[0], puntos[2].position, new Quaternion(0, 180, 0, 0));
                        seg0.transform.localScale /= 2;
                        seg0.name = "S0";
                        changeS = false;
                        break;
                    case 1:
                        Destroy(GameObject.Find("S0"));
                        GameObject seg1 = Instantiate(numeros[1], puntos[2].position, new Quaternion(0, 180, 0, 0));
                        seg1.transform.localScale /= 2;
                        seg1.name = "S1";
                        changeS = false;
                        break;
                    case 2:
                        Destroy(GameObject.Find("S1"));
                        GameObject seg2 = Instantiate(numeros[2], puntos[2].position, new Quaternion(0, 180, 0, 0));
                        seg2.transform.localScale /= 2;
                        seg2.name = "S2";
                        changeS = false;
                        break;
                    case 3:
                        Destroy(GameObject.Find("S2"));
                        GameObject seg3 = Instantiate(numeros[3], puntos[2].position, new Quaternion(0, 180, 0, 0));
                        seg3.transform.localScale /= 2;
                        seg3.name = "S3";
                        changeS = false;
                        break;
                    case 4:
                        Destroy(GameObject.Find("S3"));
                        GameObject seg4 = Instantiate(numeros[4], puntos[2].position, new Quaternion(0, 180, 0, 0));
                        seg4.transform.localScale /= 2;
                        seg4.name = "S4";
                        changeS = false;
                        break;
                    case 5:
                        Destroy(GameObject.Find("S4"));
                        GameObject seg5 = Instantiate(numeros[5], puntos[2].position, new Quaternion(0, 180, 0, 0));
                        seg5.transform.localScale /= 2;
                        seg5.name = "S5";
                        changeS = false;
                        break;

                }
            }

            if (changeM1)
            {
                switch (min1)
                {
                    case 0:
                        Destroy(GameObject.Find("M19"));
                        GameObject min10 = Instantiate(numeros[0], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min10.transform.localScale /= 2;
                        min10.name = "M10";
                        changeM1 = false;
                        break;
                    case 1:
                        Destroy(GameObject.Find("M10"));
                        GameObject min11 = Instantiate(numeros[1], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min11.transform.localScale /= 2;
                        min11.name = "M11";
                        changeM1 = false;
                        break;
                    case 2:
                        Destroy(GameObject.Find("M11"));
                        GameObject min12 = Instantiate(numeros[2], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min12.transform.localScale /= 2;
                        min12.name = "M12";
                        changeM1 = false;
                        break;
                    case 3:
                        Destroy(GameObject.Find("M12"));
                        GameObject min13 = Instantiate(numeros[3], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min13.transform.localScale /= 2;
                        min13.name = "M13";
                        changeM1 = false;
                        break;
                    case 4:
                        Destroy(GameObject.Find("M13"));
                        GameObject min14 = Instantiate(numeros[4], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min14.transform.localScale /= 2;
                        min14.name = "M14";
                        changeM1 = false;
                        break;
                    case 5:
                        Destroy(GameObject.Find("M14"));
                        GameObject min15 = Instantiate(numeros[5], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min15.transform.localScale /= 2;
                        min15.name = "M15";
                        changeM1 = false;
                        break;
                    case 6:
                        Destroy(GameObject.Find("M15"));
                        GameObject min16 = Instantiate(numeros[6], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min16.transform.localScale /= 2;
                        min16.name = "M16";
                        changeM1 = false;
                        break;
                    case 7:
                        Destroy(GameObject.Find("M16"));
                        GameObject min17 = Instantiate(numeros[7], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min17.transform.localScale /= 2;
                        min17.name = "M17";
                        changeM1 = false;
                        break;
                    case 8:
                        Destroy(GameObject.Find("M17"));
                        GameObject min18 = Instantiate(numeros[8], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min18.transform.localScale /= 2;
                        min18.name = "M18";
                        changeM1 = false;
                        break;
                    case 9:
                        Destroy(GameObject.Find("M18"));
                        GameObject min19 = Instantiate(numeros[9], puntos[1].position, new Quaternion(0, 180, 0, 0));
                        min19.transform.localScale /= 2;
                        min19.name = "M19";
                        changeM1 = false;
                        break;
                }
            }

            if (changeM2)
            {
                switch (min2)
                {
                    case 0:
                        Destroy(GameObject.Find("M25"));
                        GameObject min20 = Instantiate(numeros[0], puntos[0].position, new Quaternion(0, 180, 0, 0));
                        min20.transform.localScale /= 2;
                        min20.name = "M20";
                        changeM2 = false;
                        break;
                    case 1:
                        Destroy(GameObject.Find("M20"));
                        GameObject min21 = Instantiate(numeros[1], puntos[0].position, new Quaternion(0, 180, 0, 0));
                        min21.transform.localScale /= 2;
                        min21.name = "M21";
                        changeM2 = false;
                        break;
                    case 2:
                        Destroy(GameObject.Find("M21"));
                        GameObject min22 = Instantiate(numeros[2], puntos[0].position, new Quaternion(0, 180, 0, 0));
                        min22.transform.localScale /= 2;
                        min22.name = "M22";
                        changeM2 = false;
                        break;
                    case 3:
                        Destroy(GameObject.Find("M22"));
                        GameObject min23 = Instantiate(numeros[3], puntos[0].position, new Quaternion(0, 180, 0, 0));
                        min23.transform.localScale /= 2;
                        min23.name = "M23";
                        changeM2 = false;
                        break;
                    case 4:
                        Destroy(GameObject.Find("M23"));
                        GameObject min24 = Instantiate(numeros[4], puntos[0].position, new Quaternion(0, 180, 0, 0));
                        min24.transform.localScale /= 2;
                        min24.name = "M24";
                        changeM2 = false;
                        break;
                    case 5:
                        Destroy(GameObject.Find("M24"));
                        GameObject min25 = Instantiate(numeros[5], puntos[0].position, new Quaternion(0, 180, 0, 0));
                        min25.transform.localScale /= 2;
                        min25.name = "M25";
                        changeM2 = false;
                        break;

                }
            }



            Ptimer += Time.deltaTime;
            //print(inde);
            if (Ptimer >= 10)
            {
                inde = Random.Range(0, 5);
                point = new Vector3(Random.Range(-4.4f, 4.09f), Random.Range(-4.15f, 4.03f), -0.71f);

                if (inde == 0)
                {
                    GameObject Po1 = Instantiate(power[0], point, Quaternion.identity);
                    Po1.name = "doble";
                }
                if (inde == 1)
                {
                    GameObject Po2 = Instantiate(power[1], point, Quaternion.identity);
                    Po2.name = "velocidad";
                }
                if (inde == 2)
                {
                    GameObject Po3 = Instantiate(power[2], point, Quaternion.identity);
                    Po3.name = "cambio";
                }
                if (inde == 3)
                {
                    GameObject Po4 = Instantiate(power[3], point, Quaternion.identity);
                    Po4.name = "agranda";
                }
                if (inde == 4)
                {
                    GameObject Po5 = Instantiate(power[4], point, Quaternion.identity);
                    Po5.name = "IceShard2";
                }

                Ptimer = 0;
            }
        }



        if (PlayerSolo.muerte)
        {
            timeDeath += Time.deltaTime;
            print(timeDeath);

            if (timeDeath >= 2)
            {
                vidas--;
                if (vidas > 0) {
                    print("Revivio");
                    GameObject pl = Instantiate(nave, new Vector3(0.02f, -0.02f, -0.69f), Quaternion.Euler(-90, 0, 0));
                    pl.name = "playerSolo";
                    PlayerSolo.muerte = false;
                    PlayerSolo.escudo = true;
                    timeDeath = 0;
                }
            }
        }

        if (vidas == 2)
        {
            Destroy(lifes[2]); 
        }
        if (vidas == 1)
        {
            Destroy(lifes[1]);
        }


        if (vidas <= 0)
            {
                Destroy(lifes[0]);
                vidas = 0;
                GameOver.SetActive(true);
                timer = 0;

                if (Input.GetKeyDown(KeyCode.Return))
                {
                    next();
                }
            }



        if (PlayerSolo.muerte && changeScore && vidas <= 0)
        {
            switch (microS)
            {
                case 0:

                    GameObject mico0 = Instantiate(numeros[0], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico0.transform.localScale /= 2;
                    mico0.name = "MS0";
                    changeScore = false;
                    break;
                case 1:

                    GameObject mico1 = Instantiate(numeros[1], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico1.transform.localScale /= 2;
                    mico1.name = "MS1";
                    changeScore = false;
                    break;
                case 2:

                    GameObject mico2 = Instantiate(numeros[2], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico2.transform.localScale /= 2;
                    mico2.name = "MS2";
                    changeScore = false;
                    break;
                case 3:

                    GameObject mico3 = Instantiate(numeros[3], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico3.transform.localScale /= 2;
                    mico3.name = "MS3";
                    changeScore = false;
                    break;
                case 4:

                    GameObject mico4 = Instantiate(numeros[4], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico4.transform.localScale /= 2;
                    mico4.name = "MS4";
                    changeScore = false;
                    break;
                case 5:

                    GameObject mico5 = Instantiate(numeros[5], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico5.transform.localScale /= 2;
                    mico5.name = "MS5";
                    changeScore = false;
                    break;
                case 6:

                    GameObject mico6 = Instantiate(numeros[6], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico6.transform.localScale /= 2;
                    mico6.name = "MS6";
                    changeScore = false;
                    break;
                case 7:

                    GameObject mico7 = Instantiate(numeros[7], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico7.transform.localScale /= 2;
                    mico7.name = "MS7";
                    changeScore = false;
                    break;
                case 8:

                    GameObject mico8 = Instantiate(numeros[8], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico8.transform.localScale /= 2;
                    mico8.name = "MS8";
                    changeScore = false;
                    break;
                case 9:

                    GameObject mico9 = Instantiate(numeros[9], points[3].position, new Quaternion(0, 180, 0, 0));
                    mico9.transform.localScale /= 2;
                    mico9.name = "MS9LP";
                    changeM = false;
                    break;
            }

            switch (segundos)
            {
                case 0:

                    GameObject seg0 = Instantiate(numeros[0], points[2].position, new Quaternion(0, 180, 0, 0));
                    seg0.transform.localScale /= 2;
                    seg0.name = "S0";
                    changeScore = false;
                    break;
                case 1:

                    GameObject seg1 = Instantiate(numeros[1], points[2].position, new Quaternion(0, 180, 0, 0));
                    seg1.transform.localScale /= 2;
                    seg1.name = "S1";
                    changeScore = false;
                    break;
                case 2:

                    GameObject seg2 = Instantiate(numeros[2], points[2].position, new Quaternion(0, 180, 0, 0));
                    seg2.transform.localScale /= 2;
                    seg2.name = "S2";
                    changeScore = false;
                    break;
                case 3:

                    GameObject seg3 = Instantiate(numeros[3], points[2].position, new Quaternion(0, 180, 0, 0));
                    seg3.transform.localScale /= 2;
                    seg3.name = "S3";
                    changeScore = false;
                    break;
                case 4:

                    GameObject seg4 = Instantiate(numeros[4], points[2].position, new Quaternion(0, 180, 0, 0));
                    seg4.transform.localScale /= 2;
                    seg4.name = "S4";
                    changeScore = false;
                    break;
                case 5:

                    GameObject seg5 = Instantiate(numeros[5], points[2].position, new Quaternion(0, 180, 0, 0));
                    seg5.transform.localScale /= 2;
                    seg5.name = "S5";
                    changeScore = false;
                    break;
            }

            switch (min1)
            {
                case 0:

                    GameObject min10 = Instantiate(numeros[0], points[1].position, new Quaternion(0, 180, 0, 0));
                    min10.transform.localScale /= 2;
                    min10.name = "M10";
                    changeScore = false;
                    break;
                case 1:

                    GameObject min11 = Instantiate(numeros[1], points[1].position, new Quaternion(0, 180, 0, 0));
                    min11.transform.localScale /= 2;
                    min11.name = "M11";
                    changeScore = false;
                    break;
                case 2:

                    GameObject min12 = Instantiate(numeros[2], points[1].position, new Quaternion(0, 180, 0, 0));
                    min12.transform.localScale /= 2;
                    min12.name = "M12";
                    changeScore = false;
                    break;
                case 3:

                    GameObject min13 = Instantiate(numeros[3], points[1].position, new Quaternion(0, 180, 0, 0));
                    min13.transform.localScale /= 2;
                    min13.name = "M13";
                    changeScore = false;
                    break;
                case 4:
;
                    GameObject min14 = Instantiate(numeros[4], points[1].position, new Quaternion(0, 180, 0, 0));
                    min14.transform.localScale /= 2;
                    min14.name = "M14";
                    changeScore = false;
                    break;
                case 5:

                    GameObject min15 = Instantiate(numeros[5], points[1].position, new Quaternion(0, 180, 0, 0));
                    min15.transform.localScale /= 2;
                    min15.name = "M15";
                    changeScore = false;
                    break;
                case 6:

                    GameObject min16 = Instantiate(numeros[6], points[1].position, new Quaternion(0, 180, 0, 0));
                    min16.transform.localScale /= 2;
                    min16.name = "M16";
                    changeScore = false;
                    break;
                case 7:

                    GameObject min17 = Instantiate(numeros[7], points[1].position, new Quaternion(0, 180, 0, 0));
                    min17.transform.localScale /= 2;
                    min17.name = "M17";
                    changeScore = false;
                    break;
                case 8:

                    GameObject min18 = Instantiate(numeros[8], points[1].position, new Quaternion(0, 180, 0, 0));
                    min18.transform.localScale /= 2;
                    min18.name = "M18";
                    changeScore = false;
                    break;
                case 9:

                    GameObject min19 = Instantiate(numeros[9], points[1].position, new Quaternion(0, 180, 0, 0));
                    min19.transform.localScale /= 2;
                    min19.name = "M19";
                    changeScore = false;
                    break;
            }

            switch (min2)
            {
                case 0:

                    GameObject min20 = Instantiate(numeros[0], points[0].position, new Quaternion(0, 180, 0, 0));
                    min20.transform.localScale /= 2;
                    min20.name = "M20";
                    changeScore = false;
                    break;
                case 1:

                    GameObject min21 = Instantiate(numeros[1], points[0].position, new Quaternion(0, 180, 0, 0));
                    min21.transform.localScale /= 2;
                    min21.name = "M21";
                    changeScore = false;
                    break;
                case 2:

                    GameObject min22 = Instantiate(numeros[2], points[0].position, new Quaternion(0, 180, 0, 0));
                    min22.transform.localScale /= 2;
                    min22.name = "M22";
                    changeScore = false;
                    break;
                case 3:

                    GameObject min23 = Instantiate(numeros[3], points[0].position, new Quaternion(0, 180, 0, 0));
                    min23.transform.localScale /= 2;
                    min23.name = "M23";
                    changeScore = false;
                    break;
                case 4:

                    GameObject min24 = Instantiate(numeros[4], points[0].position, new Quaternion(0, 180, 0, 0));
                    min24.transform.localScale /= 2;
                    min24.name = "M24";
                    changeScore = false;
                    break;
                case 5:

                    GameObject min25 = Instantiate(numeros[5], points[0].position, new Quaternion(0, 180, 0, 0));
                    min25.transform.localScale /= 2;
                    min25.name = "M25";
                    changeScore = false;
                    break;

            }

        }
    }

    public void next()
    {
        PlayerPrefs.SetInt("micoS", microS);
        PlayerPrefs.SetInt("segS", segundos);
        PlayerPrefs.SetInt("min1S", min1);
        PlayerPrefs.SetInt("min2S", min2);

        SceneManager.LoadScene("resultSolo");

        luces.lucesINT = 1;

    }
}
