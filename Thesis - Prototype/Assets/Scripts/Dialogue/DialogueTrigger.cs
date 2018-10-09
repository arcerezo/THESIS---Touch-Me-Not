using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public bool lockDialogue = false;
	public Dialogue dialogue;
	

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			TriggerDialogue();
			lockDialogue = true;
			Debug.Log("locked");
		}
	}

	public void TriggerDialogue ()
	{
		if(!lockDialogue)
		{
			FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
		}
	}

	public void UnlockDialogue ()
	{
		lockDialogue = false;
		Debug.Log("unlocked");
	}
}