using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutscenesDialogue : MonoBehaviour {

	public Text nameText;
	public Text DialogueConvo;
	public Dialogue dialogue;
	//variable that keep track all the sentences 
	//declaring an array
	//public string [] sentences;


	//data type queue are used for list just like an array
	//it reads an algorithm in FIFO
	private Queue<string> sentences;
	// Use this for initialization
	void Start () {
		sentences = new Queue <string>();
		if(this.gameObject.activeInHierarchy) 
		{
			StartDialogue(dialogue);
		}
	}
	public void StartDialogue(Dialogue dialogue){

		nameText.text = dialogue.name1;

		//Debug.Log ("starting covo with " + dialogue.name);
		sentences.Clear ();

		foreach (string sentence in dialogue.sentences) {
			sentences.Enqueue (sentence);
		}
		DisplayNextSentence ();
	}
	public void DisplayNextSentence (){

		if (sentences.Count == 0) {

			endConvo ();
			return;
		}
		string sentence = sentences.Dequeue();
		DialogueConvo.text = sentence;
		
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));

		//Debug.Log (sentence);

	}
	IEnumerator TypeSentence (string sentence)
	{
		DialogueConvo.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			DialogueConvo.text += letter;
			yield return null;
		}
	}

	void endConvo(){
		Debug.Log ("end");
	}
}
