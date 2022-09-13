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
        animator.SetBool("isMoving", true);
        //animator.SetBool("isMoving", true);
        /*time += Time.deltaTime;
        print("the time is: " + time.ToString("integer"));
        if (time % 5 == 0)
        {
            animator.SetBool("isMoving", true);
        }
        if (time % 2 == 0)
        {
            animator.SetBool("isMoving", false);
        }*/

        /*print("your place is: " + agent.transform.position);
        if(agent.transform.position == new Vector3(-7, 3, -35) ||
            agent.transform.position == new Vector3(-10, 3, -28)
            )
        {
            animator.SetBool("isMoving", false);
            yield return new WaitForSeconds(10f);
        }*/

        StartCoroutine(changeState());

        //animator.SetBool("isMoving", true);
        agent.SetDestination(target.transform.position);
    }

    IEnumerator changeState()
    {
        print("hello1");
        if (agent.transform.position.x == -7 &&
            agent.transform.position.x == 3 &&
            agent.transform.position.x == -35
           )
        {
            print("hello2");
            agent.SetDestination(agent.transform.position);
            animator.SetBool("isMoving", false);
            yield return new WaitForSeconds(5f);
            animator.SetBool("isMoving", true);
            agent.SetDestination(target.transform.position);
            print("hello3");
        }
            
    }
}
