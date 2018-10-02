using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CutsceneDialogueTrigger : MonoBehaviour {

	public Dialogue dialog;

	public void triggerDialogue(){
		
		//FindObjectOfType<DialogueManager> ().StartDialogue (dialog);
		FindObjectOfType<DialogueManager>().StartDialogue(dialog);
		
	}



}
