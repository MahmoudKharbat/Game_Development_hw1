using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    CharacterController cController;
    float rotationAroundY = 0;
    float rotationAroundX = 0;
    float angularSpeed = 5f;
    float horizontalInput;
    float speed=5f;
    public GameObject aCamera; // public means that it must be connected to some object in Unity
    AudioSource sound;

    // Start is called before the first frame update
    void Start()
    {
        cController = GetComponent<CharacterController>(); // connect to Character controller of player
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float deltaz; 

        rotationAroundX = -Input.GetAxis("Mouse Y") * angularSpeed ;
        // rotates only camera
        aCamera.transform.Rotate(new Vector3(rotationAroundX, 0, 0));
        
        rotationAroundY = Input.GetAxis("Mouse X")*angularSpeed;
        transform.Rotate(new Vector3(0, rotationAroundY, 0));

        // Time.deltaTime is time btween frames
        deltaz = speed*Input.GetAxis("Vertical")*Time.deltaTime; // can be {1,0,-1}

        if (deltaz > 0.01f && !sound.isPlaying)
            sound.Play();

        Vector3 motion = new Vector3(0, -0.5f, -deltaz);// always forward in Local coordinates
        motion = transform.TransformDirection(motion); // transforms motion to GLOBAL coordinates
        cController.Move(motion);// gets vector in GLOBAL coordinates
    }
}
