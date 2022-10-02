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
        yield return new WaitForSeconds(60f);
        while (npcCount < 4)
        {
            x = Random.Range(4, 6);
            z = Random.Range(-43, -41);
            //yield return new WaitForSeconds(5f);
            Instantiate(npcs[npcCount], new Vector3(x, 1.5f, z), Quaternion.identity);
            yield return new WaitForSeconds(2f);
            npcCount++;
            if(npcCount == 4)
            {
                yield return new WaitForSeconds(60f);
                npcCount = 0;
            }
                
        }
    }
}
