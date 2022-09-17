using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNpcTarget : MonoBehaviour
{
    public GameObject npc;
    private int targetCounter = 1;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == npc.gameObject)
        {
            if (targetCounter == 5)
            {
                targetCounter = 0;
            }
            if (targetCounter == 4)
            {
                transform.position = new Vector3(-7, 3, -35);
                targetCounter = 5;
            }
            if (targetCounter == 3)
            {
                transform.position = new Vector3(-10.5f, 3, -37);
                targetCounter = 4;
            }
            if (targetCounter == 2)
            {
                transform.position = new Vector3(-10.5f, 3, -34);
                targetCounter = 3;
            }
            if (targetCounter == 1)
            {
                transform.position = new Vector3(-10.5f, 3, -32);
                targetCounter = 2;
            }
            if (targetCounter == 0)
            {
                transform.position = new Vector3(-10.5f, 3, -27);
                targetCounter = 1;
            }
        }
    }
}
