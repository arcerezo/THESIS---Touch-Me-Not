using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

	public Dialogue dialogue;
	public bool lockDialogue = false;

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
	}
}