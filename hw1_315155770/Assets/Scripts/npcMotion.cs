using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcMotion : MonoBehaviour
{
    Animator animator;
    private NavMeshAgent agent;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(changeState());
        animator.SetBool("isMoving", true);
        agent.SetDestination(target.transform.position);
    }

    IEnumerator changeState()
    {
        //animator.SetInteger("npcState", 0);// stand
        yield return new WaitForSeconds(10f);
        //animator.SetInteger("npcState", 1);// walk
    }

    IEnumerator changeTargetDelay()
    {
        yield return new WaitForSeconds(5f);
        changeState();
    }
}
