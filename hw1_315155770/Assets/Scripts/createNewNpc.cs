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
        yield return new WaitForSeconds(20f);
        while (npcCount < 4)
        {
            x = Random.Range(2, 6);
            z = Random.Range(-43, -41);
            Instantiate(npcs[npcCount], new Vector3(x, 1.5f, z), Quaternion.identity);
            yield return new WaitForSeconds(3f);
            npcCount++;
            if(npcCount == 4)
            {
                yield return new WaitForSeconds(15f);
                npcCount = 0;
            }
                
        }
    }
}
