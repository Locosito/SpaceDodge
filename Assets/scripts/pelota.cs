using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    public static bool velocidad = false;
    public static bool doble = false;
    private bool turbo = false;
    public static bool cambio = false;
    public static bool agranda = false;

    private bool choqueX = false;
    private bool choqueY = false;
    public GameObject splash;

    public static bool solo = true; 

    public float speedX;
    public float speedY;

    public static bool copiaB = false;

    private float timeToDeath = 0;
    private float timeToAgranda = 0;
    private float timeToSpeed = 0;

    private float intensify;

    public GameObject asteroide;
    private float rotX;
    private float rotY;


    public GameObject ball;

    void Start()
    {
        intensify = 0;
            
        speedX = 3;
        speedY = 3;

        agranda = false;
        cambio = false;
        doble = false;
        velocidad = false;


        if (copiaB)
        {
            speedX *= -1;
            speedY *= -1;
        }

        rotX = 3;
        rotY = 3;

    }

    void Update()
    {

        asteroide.transform.rotation = Quaternion.Euler(asteroide.transform.rotation.x + rotX,
            asteroide.transform.rotation.y + rotY , 0);

        if (speedX > 0)
        {
            rotY += 2;
        }
        else
        {
            rotY += 2;
        }

        if (speedY > 0)
        {
            rotX += 2;
        }
        else
        {
            rotX += 2;
        }

        intensify += Time.deltaTime;

        if(intensify >= 20)
        {
            if(speedX > 0)
            {
                speedX += 1;
            }
            else
            {
                speedX -= 1;
            }

            if (speedY > 0)
            {
                speedY += 1;
            }
            else
            {
                speedY -= 1;
            }

            intensify = 0;
        }
        //print(agranda);
        if (agranda)
        {
            timeToAgranda += Time.deltaTime;

                if (transform.localScale.x <= 0.7f)
                {
                //print("agranda");
                    transform.localScale = new Vector3(transform.localScale.x + 0.1f * Time.deltaTime,
                        transform.localScale.y + 0.1f * Time.deltaTime
                        , transform.localScale.z + 0.1f * Time.deltaTime);
                }
            
            if (timeToAgranda >= 15)
            {
                agranda = false;
                timeToAgranda = 0;
            }
        }

        if (!agranda)
        {
            if (transform.localScale.x >= 0.3f)
            {
                //print("encoger");
                transform.localScale = new Vector3(transform.localScale.x - 0.1f * Time.deltaTime, transform.localScale.y - 0.1f * Time.deltaTime
                    , transform.localScale.z - 0.1f * Time.deltaTime);
            }
        }


        if (gameObject.name == "pelota")
        {
            copiaB = false;
        }
        else
        {
            copiaB = true;
        }

        if (copiaB)
        {
            timeToDeath += Time.deltaTime;
            if (timeToDeath >= 30)
            {
                Instantiate(splash,transform.position,Quaternion.identity);
                Destroy(gameObject);
            }
        }

        if (velocidad)
        {
            speedX *= 2;
            speedY *= 2;
            turbo = true;
            velocidad = false;
        }
        if (turbo)
        {
            timeToSpeed += Time.deltaTime;
            if (timeToSpeed >= 15)
            {
                speedX /= 2;
                speedY /= 2;
                timeToSpeed = 0;
                turbo = false;
            }
        }

        if (doble)
        {
            GameObject copia = Instantiate(ball, transform.position, Quaternion.identity);
            copia.name = "copia";
            doble = false;
            copiaB = true;
        } 

        if (transform.position.y >= 4.621)
        {
            transform.position = new Vector3(transform.position.x, 4.621f, transform.position.z);
            choqueY = true;
            speedY *= -1; 
        }

        if (transform.position.y <= -4.482)
        {
            transform.position = new Vector3(transform.position.x, -4.482f, transform.position.z);
            choqueY = true;
            speedY *= -1;
        }

        if (transform.position.x >= 8.515)
        {
            transform.position = new Vector3(8.515f, transform.position.y , transform.position.z);
            choqueX = true;
            speedX *= -1;
        }

        if (transform.position.x <= -8.564)
        {
            transform.position = new Vector3(-8.564f, transform.position.y , transform.position.z);
            choqueX = true;
            speedX *= -1;
        }


        transform.position = new Vector3(transform.position.x + speedX * Time.deltaTime, transform.position.y + speedY * Time.deltaTime
            , transform.position.z);


        if (choqueY)
        {
            
            Vector3 spanwY = transform.position;
            Instantiate(splash, spanwY, Quaternion.identity);
            choqueY = false;
        }

        if (choqueX)
        {
            
            Vector3 spanwX = transform.position;
            Instantiate(splash, spanwX, Quaternion.identity);
            choqueX = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "doble")
        {
            doble = true;
            powerPop.dobleV = true;
            Destroy(other.gameObject);
        }

        if (other.name == "velocidad")
        {
            velocidad = true;
            if (turbo)
            {
                timeToSpeed = 0;
                print("Add");

            }
            powerPop.velocidadV = true;
            Destroy(other.gameObject);
        }

        if(other.name == "agranda")
        {
            agranda = true;
            if (agranda)
            {
                timeToAgranda = 0;
                print("Add");
            }
            powerPop.agrandaV = true;
            Destroy(other.gameObject);
        }

        if (other.name == "cambio")
        {
            cambio = true;
            if (cambio)
            {
                PlayerSolo.timeToCambio = 0;
                player2.timeToCambio = 0;
                player.timeToCambio = 0;
                print("Add");

            }
            powerPop.cambioV = true;
            Destroy(other.gameObject);
        }
    }
}
