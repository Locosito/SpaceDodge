using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUps : MonoBehaviour
{
    private float timer;
    private float speedX = 1;
    private float speedY = 1;

    void Start()
    {
        transform.localScale = new Vector3(0, 0, 0);
    }

    void Update()
    {
        timer += Time.deltaTime;
        if(timer < 10)
        {
            if(transform.localScale.x <= 0.4f)
                    {
                        transform.localScale = new Vector3(transform.localScale.x + 0.05f, transform.localScale.y + 0.05f, transform.localScale.z + 0.05f);
                    }
        }
        
        if(timer >= 10)
        {
            transform.localScale = new Vector3(transform.localScale.x - 0.05f, transform.localScale.y - 0.05f, transform.localScale.z - 0.05f);
        }

        if(transform.localScale.x <= 0)
        {
            Destroy(gameObject);
        }


        if (transform.position.y >= 4.03f || transform.position.y <= -4.15f)
        {
            speedY *= -1;
        }

        if (transform.position.x >= 4.09f || transform.position.x <= -4.4f)
        {
            speedX *= -1;
        }


        transform.position = new Vector3(transform.position.x + speedX * Time.deltaTime, transform.position.y + speedY * Time.deltaTime
            , transform.position.z);
    }
}
