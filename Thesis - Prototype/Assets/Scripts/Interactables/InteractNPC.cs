using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InteractNPC : Interactable {

	public Sprite npcSprite;
	public Image activeNPC;
	public override void Interact() {
		base.Interact();

		InteractWithNPC();

		activeNPC.sprite = npcSprite;
	}

	void InteractWithNPC() {
//		Debug.Log("Interactable NPC Detected");
//		interact.gameObject.SetActive(true);
//      dialogue.gameObject.SetActive(true);
	}
}
