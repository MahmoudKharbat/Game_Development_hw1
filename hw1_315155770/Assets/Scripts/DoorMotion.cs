using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    private Animator animator;
    private AudioSource audioSrc;

    public string animationVarName = "";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {

        /* animator.SetBool("isOpenning", true);
         animator.SetBool("isSmallDoorOpenning", true);
         animator.SetBool("isStockRoomDoorOpenning", true);
         animator.SetBool("isBathroomMainDoorOpenning", true);
         animator.SetBool("isBathroomDoor1Openning", true);
         animator.SetBool("isBathroomDoor2Openning", true);
         */
        animator.SetBool(animationVarName, true);
        audioSrc.PlayDelayed(0.5f);
    }
  
    private void OnTriggerExit(Collider other)
    {
        /*animator.SetBool("isOpenning", false);
        animator.SetBool("isSmallDoorOpenning", false);
        animator.SetBool("isStockRoomDoorOpenning", false);
        animator.SetBool("isBathroomMainDoorOpenning", false);
        animator.SetBool("isBathroomDoor1Openning", false);
        animator.SetBool("isBathroomDoor2Openning", false);*/
        animator.SetBool(animationVarName, false);
        audioSrc.PlayDelayed(0.5f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
