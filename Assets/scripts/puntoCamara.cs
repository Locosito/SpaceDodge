using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puntoCamara : MonoBehaviour
{
    public Camera cmr;
    public Transform target;

    void Start()
    {
        cmr = GameObject.Find("Main Camera").GetComponent<Camera>();
        target = GameObject.Find("target").transform;
    }

    
    void Update()
    {
        cmr.transform.LookAt(target, Vector3.zero);
    }
}
