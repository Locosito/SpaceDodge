using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTutorial : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "p1" || other.name == "p2")
        {
            ManagerDuoTutorial.nextT += 1;
            Destroy(gameObject);
        }
    }
}
