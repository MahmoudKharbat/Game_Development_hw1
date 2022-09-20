using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createNewNpc : MonoBehaviour
{
    public GameObject[] npcs;
    public int x;
    public int z;
    public int npcCount;

    void Start()
    {
        StartCoroutine(addNpc());
    }

    IEnumerator addNpc()
    {
        while (npcCount < 4)
        {
            x = Random.Range(-20, 7);
            z = Random.Range(-6, 1);
            Instantiate(npcs[npcCount], new Vector3(x, 1.5f, z), Quaternion.identity);
            yield return new WaitForSeconds(5f);
            npcCount++;
        }
    }
}