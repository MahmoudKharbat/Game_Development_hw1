using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawerMotion : MonoBehaviour
{
    private Animator animator;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GetComponent<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player.gameObject)
            animator.SetBool("isDoorOpenning", true);
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool("isDoorOpenning", false);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
