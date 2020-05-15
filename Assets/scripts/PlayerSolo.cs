using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSolo : MonoBehaviour
{
    private float speed = 6;
    private Vector3 death;
    public GameObject splash;
    public static bool muerte = false;
    private float limite1 = -4.15f;
    private float limite2 = 4.09f;
    private float limite3 = 8.03f;
    private float limite4 = -8.07f;
    public static float timeToCambio = 0;
    public static bool escudo = false;
    private float timeToEscudo = 0;

    public GameObject UFO;
    private int rot;

    public GameObject padre;

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

        if (timer >= 20)
        {
            speed += 0.3f;
            timer = 0;
        }

        rot += 7;
        UFO.transform.localRotation = Quaternion.Euler(0, rot, 0);

        if(rot >= 360)
        {
            rot = 0;
        }

        if (!pelota.cambio)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * speed, limite1, limite2),
                                     transform.position.z);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * -speed, limite1, limite2),
                                     transform.position.z);
            }

            if (Input.GetKey(KeyCode.A))
            {
               transform.position = new Vector3(Mathf.Clamp(transform.position.x + Time.deltaTime * -speed, limite4, limite3),
                                     transform.position.y,
                                     transform.position.z);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x + Time.deltaTime * speed, limite4, limite3),
                                     transform.position.y,
                                     transform.position.z);
            }
        }
        if (pelota.cambio)
        {
            timeToCambio += Time.deltaTime;
            if (Input.GetKey(KeyCode.W))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * -speed, limite1, limite2),
                                     transform.position.z);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(transform.position.x,
                                     Mathf.Clamp(transform.position.y + Time.deltaTime * speed, limite1, limite2),
                                     transform.position.z);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x + Time.deltaTime * speed, limite4, limite3),
                                      transform.position.y,
                                      transform.position.z);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x + Time.deltaTime * -speed, limite4, limite3),
                                     transform.position.y,
                                     transform.position.z);
            }

            if (timeToCambio >= 15)
            {
                pelota.cambio = false;
            }
        }

        if (muerte)
        {
            GameObject P1 = Instantiate(splash, transform.position, Quaternion.identity);
            pelota.cambio = false;
            Destroy(padre);
            Destroy(gameObject);

        }

        if (escudo)
        {
            //print(escudo);
            shield.SetActive(true);
            timeToEscudo += Time.deltaTime;
            if (timeToEscudo >= 3)
            {
                escudo = false;
                shield.SetActive(false);
                timeToEscudo = 0;
            }
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (!escudo)
        {
            if (other.name == "pelota" || other.name == "copia" || other.tag == "bala")
            {
                
                muerte = true;
            }
        }

    }
}
