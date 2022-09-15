using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class npcMotion : MonoBehaviour
{
    private Animator animator;
    private NavMeshAgent agent;
    public GameObject target;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }

    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(changeState(other));
    }


    IEnumerator changeState(Collider other)
    {
        animator.SetBool("isMoving", true);
        if (target.gameObject == other.gameObject)
        {
            agent.enabled = false;
            animator.SetBool("isMoving", false);
            yield return new WaitForSeconds(5f);
            animator.SetBool("isMoving", true);
            agent.enabled = true;
        }
            
    }
}
