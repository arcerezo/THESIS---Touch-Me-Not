using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;
	public Animator animator;
	private Queue<string> sentences;
	private Movement thePlayer;
	public DialogueTrigger dTriggerS;
	public DialogueTrigger dTriggerD;
	public GameObject dialogueTrigger;
	public InteractNPC interact;
	public Dialogue dialogue;
	public Sprite s1, s2;
	public bool sprite1Active = false;

	void Start () {
		sentences = new Queue<string>();
		thePlayer = FindObjectOfType<Movement>();
	}

	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
			DisplayNextSentence();
			
			dialogue.name2 = "CRISOSTOMO IBARRA";
			if(sprite1Active)
			{
			interact.activeNPC.sprite = s2;
			nameText.text = dialogue.name2;
			sprite1Active = false;
			}
			else
			{
				interact.activeNPC.sprite = s1;
				nameText.text = dialogue.name1;
				sprite1Active = true;
			}
		}
		
		if (dialogueTrigger.activeInHierarchy)
		{
			dTriggerS = FindObjectOfType<DialogueTrigger>();
			dTriggerD = FindObjectOfType<DialogueTrigger>();
		}
	}

	public void StartDialogue (Dialogue dialogue)
	{
		animator.SetBool("IsOpen", true);

		thePlayer.canMove = false;

		interact.activeNPC.sprite = s1;

		nameText.text = dialogue.name1;
		sprite1Active = true;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}
			DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
		animator.SetBool("IsOpen", false);
		thePlayer.canMove = true;
		dTriggerS.UnlockDialogue();
		dTriggerD.UnlockDialogue();
	}

}