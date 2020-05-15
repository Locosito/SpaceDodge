using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STutorial : MonoBehaviour
{
    private bool suma = false;

    void Update()
    {
        if (suma)
        {
            ManagerSoloTutorial.nextTS += 1;
            Destroy(gameObject);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "playerSolo")
        {
            suma = true;

        }

        
    }
}
