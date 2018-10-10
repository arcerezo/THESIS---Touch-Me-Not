﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 6.0F;
    //public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public float rotateSpeed = 3.0F;
    private Vector3 moveDirection = Vector3.zero;
	private Vector3 rotDirection = Vector3.zero;
	public Animator anim;
	public GameObject dialogueTriggerDam, dialogueTriggerSyb, dialogueTriggerGue, dialogueTriggerPoet;
	public Interactable focus;

    public delegate void OnFocusChanged(Interactable newFocus);
	public OnFocusChanged onFocusChangedCallback;
	public bool canMove;
	
    // Use this for initialization
    void Start()
    {
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
		if (!canMove) 
		{
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            return;
        }

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            // if (Input.GetButton("Jump"))
            //     moveDirection.y = jumpSpeed;

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        //Rotate Player
		rotDirection = new Vector3(0, Input.GetAxis("Horizontal"), 0);
        transform.Rotate (rotDirection, Time.deltaTime * rotateSpeed);
		// if (moveDirection != Vector3.zero) {
        //     Quaternion lookRotation = Quaternion.LookRotation(moveDirection);
        //     transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, rotateSpeed * Time.deltaTime);
        // }
		if (moveDirection.z != 0) {
            anim.SetBool ("IsRunning", true);
        }
        else {
            anim.SetBool ("IsRunning", false);
        }
    }

	void OnTriggerEnter(Collider coll)
    {
        // Interact with items
        if (coll.gameObject.tag == "Item") {
            SetFocus(coll.GetComponent<Collider>().GetComponent<Interactable>());
        }

        //Interact with NPC
        else if(coll.gameObject.name == "Sybila")
        {
            dialogueTriggerSyb.SetActive(true);
        }
        else if (coll.gameObject.name == "Damaso")
        {
            dialogueTriggerDam.SetActive(true);
        }
        else if (coll.gameObject.name == "Guevarra")
        {
            dialogueTriggerGue.SetActive(true);
        }
        else if(coll.gameObject.name == "Poet")
        {
            dialogueTriggerPoet.SetActive(true);
        }
        SetFocus(coll.GetComponent<Collider>().GetComponent<Interactable>());
    }

    void OnTriggerExit(Collider coll)
    {
        if (coll.gameObject.tag == "NPC")
        {
            dialogueTriggerSyb.SetActive(false);
            dialogueTriggerDam.SetActive(false);
            dialogueTriggerGue.SetActive(false);
            dialogueTriggerPoet.SetActive(false);
            RemoveFocus();
        }
    }
    void SetFocus (Interactable newFocus)
	{
		if (onFocusChangedCallback != null)
			onFocusChangedCallback.Invoke(newFocus);

		// If our focus has changed
		if (focus != newFocus && focus != null)
		{
			// Let our previous focus know that it's no longer being focused
			focus.OnDefocused();
		}

		// Set our focus to what we hit
		// If it's not an interactable, simply set it to null
		focus = newFocus;

		if (focus != null)
		{
			// Let our focus know that it's being focused
			focus.OnFocused(transform);
		}

	}
    void RemoveFocus() {
        focus = null;
    }

    //TEST FOR ANDROID

    // void MoveForward {
        
    // }
}