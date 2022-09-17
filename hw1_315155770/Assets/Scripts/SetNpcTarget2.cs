using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNpcTarget2 : MonoBehaviour
{
    public static readonly int targets = 5;
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
        if (other.gameObject == npc.gameObject)
        {
            if (targetCounter == 4)
            {
                targetCounter = 0;
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
                transform.position = new Vector3(5.5f,11,-34);
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
