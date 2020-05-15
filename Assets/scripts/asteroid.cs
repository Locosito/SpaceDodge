using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class asteroid : MonoBehaviour
{
    private float rotX;
    private float rotY;
    private float speed;
    public GameObject asteroide;

    void Start()
    {
        rotX = 10;
        rotY = 10;
    }

    void Update()
    {
        rotX += Time.deltaTime * 20;
        rotY += Time.deltaTime * 20;
        speed += Time.deltaTime * 5;

        transform.rotation = Quaternion.Euler(transform.rotation.x + rotX,
            transform.rotation.y + rotY, 0);

        if(gameObject.name == "asteroidR")
        {
            transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

        if (gameObject.name == "asteroidL")
        {
            transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
        }

    }

    void OnTriggerEnter(Collider other)
    {
            if (other.name == "Lluvia")
            {
                print("hola");
                Destroy(gameObject);
            }
    }
}
