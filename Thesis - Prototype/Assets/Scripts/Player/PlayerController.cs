﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject player;
    public float movementSpeed = 0.5f;
    static Animator anim;
    public Interactable focus;
    
    public delegate void OnFocusChanged(Interactable newFocus);
	public OnFocusChanged onFocusChangedCallback;
    public GameObject dialogueTrigger;
    public bool canMove = true;
    
    void Start() {
        anim = GetComponent<Animator>();
        canMove = true;
    }

    void Update() {
        float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");
        
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if(movement != Vector3.zero) {
            Quaternion lookRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation, lookRotation, movementSpeed * Time.deltaTime);
        }
        transform.Translate (movement * movementSpeed * Time.deltaTime, Space.World);
        if(moveVertical != 0 || moveHorizontal != 0) {
            anim.SetBool ("IsRunning", true);
        }
        else {
            anim.SetBool ("IsRunning", false);
        }
    }
    
    void OnTriggerEnter(Collider coll)
    {
        // Interact with items
        if(coll.gameObject.name == "Item") {
            SetFocus(coll.GetComponent<Collider>().GetComponent<Interactable>());

        }
        //Interact with NPC
        else if(coll.gameObject.name == "NPC") {
            dialogueTrigger.SetActive(true);
            SetFocus(coll.GetComponent<Collider>().GetComponent<Interactable>());
        }
    }

    void OnTriggerExit(Collider coll)
    {
        if(coll.gameObject.name == "NPC")
        {
            dialogueTrigger.SetActive(false);
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
}