using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSrc;
    public GameObject npc;
    public string animationVarName = "";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
        npc = GetComponent<GameObject>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == npc.gameObject)
        {
            animator.SetBool(animationVarName, true);
            audioSrc.PlayDelayed(0.5f);
        }
    }
  
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == npc.gameObject)
        {
            animator.SetBool(animationVarName, false);
            audioSrc.PlayDelayed(0.5f);
        }   
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
