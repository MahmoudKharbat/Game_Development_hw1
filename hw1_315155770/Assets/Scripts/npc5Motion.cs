using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npc5Motion : MonoBehaviour
{
    //private int targetsNum;
    private int currTarget = 0;
    private NavMeshAgent agent;
    public GameObject[] targets;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        agent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //animator.SetInteger("state", 1);
        if (agent.enabled)
            agent.SetDestination(targets[currTarget].transform.position);
    }

    IEnumerator changeState(int op)
    {
        switch (op)
        {
            case 0:// walking
                agent.enabled = true;
                animator.SetInteger("state", 1);
                break;

            case 1: // reach the dest - standing - and then start walking again
                print("hello1");
                agent.enabled = false;
                animator.SetInteger("state", 0);
                yield return new WaitForSeconds(5f);
                agent.enabled = true;
                animator.SetInteger("state", 1);
                break;

            case 2: // reach the dest - sitting - and then start walking again
                print("hello2");
                agent.enabled = false;
                animator.SetInteger("state", 2);
                yield return new WaitForSeconds(5f);
                agent.enabled = true;
                animator.SetInteger("state", 0);
                break;
        }
    }

    IEnumerator makeDelay(float time)
    {
        print("we are in makeDelay");
        yield return new WaitForSeconds(time);
    }

    private void OnTriggerEnter(Collider other)
    {       
        if (targets[currTarget].gameObject == other.gameObject)
        {
            if (currTarget != 4)
                StartCoroutine(changeState(1));
            else
                StartCoroutine(changeState(2));
            currTarget++;
            currTarget %= targets.Length;
        }
        else
        {
            //StartCoroutine(makeDelay(10f));
            StartCoroutine(changeState(0));
        }
    }
}
