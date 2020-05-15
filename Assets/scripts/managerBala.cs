using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerBala : MonoBehaviour
{
    public GameObject[] balas;
    private int num = 4;
    private bool disparos = false;
    public GameObject cluster;
    public GameObject explote;
    private float timer;
    List<pelota> amd = new List<pelota>();
    private float distance;


    void Start()
    {
        disparos = false;
        num = 4;
        
    }

    void Update()
    {
        print(disparos);
        switch (num)
        {
            case 0:
                if(!balas[0].GetComponent<bala>().disparen)
                balas[0].GetComponent<bala>().apunten = true;

                if (balas[0].GetComponent<bala>().disparen)
                {
                    balas[0].GetComponent<bala>().apunten = false;
                    num++;
                }
                break;
            case 1:
                if (!balas[1].GetComponent<bala>().disparen)
                    balas[1].GetComponent<bala>().apunten = true;

                if (balas[1].GetComponent<bala>().disparen)
                {
                    balas[1].GetComponent<bala>().apunten = false;
                    num++;
                }
                break;
            case 2:
                if (!balas[2].GetComponent<bala>().disparen)
                    balas[2].GetComponent<bala>().apunten = true;

                if (balas[2].GetComponent<bala>().disparen)
                {
                    balas[2].GetComponent<bala>().apunten = false;
                    num++;
                }
                break;
            case 3:
                if (!balas[3].GetComponent<bala>().disparen)
                    balas[3].GetComponent<bala>().apunten = true;

                if (balas[3].GetComponent<bala>().disparen)
                {
                    balas[3].GetComponent<bala>().apunten = false;
                    timer += Time.deltaTime;
                }
                if(timer >= 2)
                {
                    num = 5;
                }
                break;
            case 4:
                if (disparos)
                {
                    num = 0;
                }
                break;
            case 5:
                Instantiate(explote, cluster.transform.position, Quaternion.identity);
                Destroy(cluster);
                break;
        }

        amd = new List<pelota>();
        foreach (pelota go in FindObjectsOfType<pelota>())
        {
            amd.Add(go);
        }

        for (int i = 0; i < amd.Count; i++)
        {
            if (Vector3.Distance(cluster.transform.position, amd[i].transform.position) < 0.6f)
            {
                disparos = true;
            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(cluster.transform.position, 0.6f);
    }

}
