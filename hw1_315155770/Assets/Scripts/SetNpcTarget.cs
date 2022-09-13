using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNpcTarget : MonoBehaviour
{
    public static readonly int targets = 5;
    public GameObject npc;
   // public GameObject[] NpcPath = new GameObject[targets];
    private int targetCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
       
    }

   /* private void setTargets()
    {
        NpcPath[0][0] = 1f;
        NpcPath[0][1] = 1f;
        NpcPath[0][2] = 1f;
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == npc.gameObject)
        {
            //transform.position = NpcPath[targetCounter].transform.position;
            if (targetCounter == 0)
            {
                transform.position = new Vector3(-12,2,-27);
                targetCounter++;
                print("Current targetCounter is : " + targetCounter);
            }
            else if (targetCounter == 1)
            {
                transform.position = new Vector3(-12, 2, -31);
                targetCounter++;
                print("Current targetCounter is : " + targetCounter);
            }
            else if (targetCounter == 2)
            {
                transform.position = new Vector3(-12, 2, -34);
                targetCounter++;
                print("Current targetCounter is : " + targetCounter);
            }
            else if (targetCounter == 3)
            {
                transform.position = new Vector3(-12, 2, -37);
                targetCounter++;
                print("Current targetCounter is : " + targetCounter);
            }
            else
            {
                transform.position = new Vector3(-5, 3, -35);
                targetCounter = 0;
                print("Current targetCounter is : " + targetCounter);
            }
        }
    }
}
