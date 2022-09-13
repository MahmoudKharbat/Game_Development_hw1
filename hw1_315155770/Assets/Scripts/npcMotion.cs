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
        // StartCoroutine(changeState());
        animator.SetInteger("npcState", 1);
        agent.SetDestination(target.transform.position);
    }

    IEnumerator changeState()
    {
        Animator animator = GetComponent<Animator>();
        animator.SetInteger("npcState", 0);// stand

        yield return new WaitForSeconds(2f);
        animator.SetInteger("npcState", 1); // walk

        yield return new WaitForSeconds(5f);
        animator.SetInteger("npcState", 2); // sit

        yield return new WaitForSeconds(5f);
    }

}
