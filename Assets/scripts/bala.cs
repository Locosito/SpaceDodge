using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public Transform target;
    [SerializeField]
    public bool apunten = false;
    [SerializeField]
    public bool disparen = false;
    private Vector3 mira;
    private Transform player;
    private float timer;
    private float distance;
    private bool rotacion = true;
    private float angulo;
    private float X;
    private float Y;
    private float posX;
    private float posY;


    void Update()
    {
        if (rotacion)
                transform.RotateAround(target.position, new Vector3(0, 1, 1), 200 * Time.deltaTime);

        if (disparen && !apunten)
            {
                distance = Vector3.Distance(transform.position, mira);
                transform.position = Vector3.MoveTowards(transform.position, mira, 12 * Time.deltaTime);

            }

        player = GameObject.Find("playerSolo").transform;


            if (apunten)
            {
                rotacion = false;

                Y = player.position.y - transform.position.y;
                X = player.position.x - transform.position.x;

                angulo = Mathf.Atan(Y / X) * 180 / Mathf.PI;

                posX = X * 4;
                posY = posX * Mathf.Tan(angulo * Mathf.PI / 180);

                mira = new Vector3(transform.position.x + posX, transform.position.y + posY, player.position.z);

                timer += Time.deltaTime;
            }

            if (timer >= 1)
            {
                apunten = false;
                disparen = true;
            }
        

        
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(mira, 0.3f);
    }
}
