using UnityEngine;
using TMPro;
public class InteractNPC : Interactable {
	public override void Interact() {
		base.Interact();

		InteractWithNPC();
	}

	void InteractWithNPC() {
//		Debug.Log("Interactable NPC Detected");
//		interact.gameObject.SetActive(true);
//      dialogue.gameObject.SetActive(true);
	}
}
