using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	public int movementspeed = 1;
	Vector3 moveVector;
	CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.A)) {
         transform.Translate (Vector3.left * movementspeed * Time.deltaTime); 
	     }
	     if(Input.GetKey (KeyCode.D)) {
	         transform.Translate (Vector3. right *   movementspeed * Time.deltaTime);
	     }
	     //Reset the MoveVector
         moveVector = Vector3.zero;
 
         //Check if character is grounded
         if (controller.isGrounded == false)
         {
             //Add our gravity Vecotr
             moveVector += Physics.gravity;
         }
 
         //Apply our move Vector , remeber to multiply by Time.delta
         controller.Move(moveVector * Time.deltaTime);
 
    }
}