using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{
    CharacterController cController;
    float rotationAroundY = 0;
    float rotationAroundX = 0;
    float angularSpeed = 100f;
    float horizontalInput;
    float speed=5f;
    public GameObject aCamera; // public means that it must be connected to some object in Unity
    // Start is called before the first frame update
    void Start()
    {
        cController = GetComponent<CharacterController>(); // connect to Character controller of player

    }

    // Update is called once per frame
    void Update()
    {
        /*float deltaz; 

        rotationAroundX = -2*Input.GetAxis("Mouse Y") * angularSpeed * Time.deltaTime;
        // rotates only camera
        aCamera.transform.Rotate(new Vector3(rotationAroundX, 0, 0));

        // simple motion of player to z axis
        // transform.position += new Vector3(0,0,-0.05f);
        
        rotationAroundY = Input.GetAxis("Mouse X")*angularSpeed * Time.deltaTime;
        transform.Rotate(new Vector3(0, rotationAroundY, 0));

        // Time.deltaTime is time btween frames
        deltaz = speed*Input.GetAxis("Vertical")*Time.deltaTime; // can be {1,0,-1}
        
        Vector3 motion = new Vector3(0, -0.5f, deltaz);// always forward in Local coordinates*/
        Vector3 motion = new Vector3(0, -0.5f, -0.05f);
        motion = transform.TransformDirection(motion); // transforms motion to GLOBAL coordinates
        cController.Move(motion);// gets vector in GLOBAL coordinates

       // GetComponent<Rigidbody>().velocity = new Vector3(horizontalInput, 0, 0);
    }
}
