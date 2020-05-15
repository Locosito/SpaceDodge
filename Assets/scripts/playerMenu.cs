using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class playerMenu : MonoBehaviour
{
    private float speed;
    public static bool muerte;
    List<pelota> amd = new List<pelota>();
    private float distance;
    public GameObject splash;

    private float limite1 = -3.71f;
    private float limite2 = 3.85f;

    private float timer = 0;

    void Start()
    {
        pelota.agranda = false;
        pelota.cambio = false;
        pelota.doble = false;
        pelota.velocidad = false;
        player.muerte = false;
        player2.muerte = false;
        PlayerSolo.muerte = false;
        muerte = false;
        timer = 0;

        if (gameObject.name == "p1bot")
        {
            transform.rotation = Quaternion.Euler(0, -90, 90f);
        }
        else {
            transform.rotation = Quaternion.Euler(180, -90, 90f);
        }
    }
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 20)
        {
            speed += 0.3f;
            timer = 0;
        }


        amd = new List<pelota>();
        foreach(pelota go in FindObjectsOfType<pelota>())
        {
            amd.Add(go);
        }

        for (int i = 0; i < amd.Count; i++)
        {
            if(Vector3.Distance(transform.position, amd[i].transform.position) < 5f)
            {
                if(amd[i].speedY > 0)
                {
                    speed = -7;
                    if (gameObject.name == "p1bot")
                    {
                        transform.rotation = Quaternion.Euler(0, -90, 120);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(180, -90, 60);
                    }
                }
                if (amd[i].speedY < 0)
                {
                    speed = 7;
                    if (gameObject.name == "p1bot")
                    {
                        transform.rotation = Quaternion.Euler(0, -90, 60);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(180, -90, 120);
                    }
                }
            }

            else
            {
                if(transform.position.y >= limite2)
                {
                    speed = -7;
                    if (gameObject.name == "p1bot")
                    {
                        transform.rotation = Quaternion.Euler(0, -90, 120);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(180, -90, 60);
                    }
                    
                }

                if(transform.position.y <= limite1)
                {
                    speed = 7;
                    if (gameObject.name == "p1bot")
                    {
                        transform.rotation = Quaternion.Euler(0, -90, 60);
                    }
                    else
                    {
                        transform.rotation = Quaternion.Euler(180, -90, 120);
                    }
                    
                }
            }
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y + Time.deltaTime * speed, limite1, limite2), transform.position.z);

        if (muerte)
        {

                if(gameObject.name == "p1bot")
                {
                    GameObject P1 = Instantiate(splash, transform.position, Quaternion.identity);
                }
                if(gameObject.name == "p2bot")
                {
                    GameObject P1 = Instantiate(splash, transform.position, Quaternion.identity);
                }
            
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "pelota" || other.name == "copia")
        {
            muerte = true;
        }
    }

    void OnDrawGizmos()
    { 
        Gizmos.color = Color.white;
        Gizmos.DrawWireSphere(transform.position, 2.5f);
    }
}
