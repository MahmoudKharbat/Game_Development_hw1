using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npc2Motion : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (agent.enabled)
            agent.SetDestination(target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(changeState(other));
    }


    IEnumerator changeState(Collider other)
    {
        if (target.gameObject == other.gameObject)
        {
            agent.enabled = false;
            animator.SetInteger("npcState", 0);
            yield return new WaitForSeconds(5f);
            animator.SetInteger("npcState", 1);
            agent.enabled = true;
        }
        else
        {
            animator.SetInteger("npcState", 1);
            agent.enabled = true;
        }
        /*else
        {
            agent.enabled = false;
            animator.SetInteger("npcState", 0);
            yield return new WaitForSeconds(5f);
            animator.SetInteger("npcState", 1);
            agent.enabled = true;
        }*/

    }
}
