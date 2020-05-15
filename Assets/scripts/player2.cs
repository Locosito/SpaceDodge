using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    
    private float speed = 3;
    private Vector3 death;
    public GameObject splash;
    public static bool muerte;

    private float limite1 = -3.71f;
    private float limite2 = 3.85f;
    public static float timeToCambio = 0;

    private bool Parriba;
    private bool Pabajo;

    public static bool escudo2 = false;
    private float timeToEscudo = 0;
    public GameObject shield;

    private float timer = 0;

    void Start()
    {
        muerte = false;
        timer = 0;
    }
    void Update()
    {
        timer += Time.deltaTime;
        
        if(timer >= 20)
        {
            speed += 0.3f;
            timer = 0;
        }

        if (!pelota.cambio)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * speed, limite1, limite2),
                                     transform.position.z);

                Parriba = true;
            }

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                Parriba = false;
                transform.rotation = Quaternion.Euler(0, 90, -90f);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * -speed, limite1, limite2),
                                     transform.position.z);

                Pabajo = true;
            }

            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                Pabajo = false;
                transform.rotation = Quaternion.Euler(0, 90, -90f);
            }
        }
        if (pelota.cambio)
        {
            timeToCambio += Time.deltaTime;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * -speed, limite1, limite2),
                                     transform.position.z);

                Pabajo = true;
            }

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                Pabajo = false;
                transform.rotation = Quaternion.Euler(0, 90, -90f);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * speed, limite1, limite2),
                                     transform.position.z);

                Parriba = true;
            }

            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                Parriba = false;
                transform.rotation = Quaternion.Euler(0, 90, -90f);
            }

            if (timeToCambio >= 15)
            {
                pelota.cambio = false;
            }
        }

        if (Parriba)
        {
            transform.rotation = Quaternion.Euler(0, 90, -60);
        }

        if (Pabajo)
        {

            transform.rotation = Quaternion.Euler(0, 90, -120);
        }


        if (muerte)
        {
            GameObject P2 = Instantiate(splash, transform.position, Quaternion.identity);
            pelota.cambio = false;
            Destroy(gameObject);
        }

        if (escudo2)
        {
            print(escudo2);
            shield.SetActive(true);
            timeToEscudo += Time.deltaTime;
            if (timeToEscudo >= 3)
            {
                escudo2 = false;
                shield.SetActive(false);
                timeToEscudo = 0;
            }
        }

    }


    void OnTriggerEnter(Collider other)
    {
        if (!escudo2)
        {
            if (other.name == "pelota" || other.name == "copia" || other.name == "asteroidL" || other.name == "asteroidR")
            {
                muerte = true;
            }
        }
    }

}
