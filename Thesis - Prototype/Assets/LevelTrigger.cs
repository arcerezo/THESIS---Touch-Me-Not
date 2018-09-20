using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTrigger : MonoBehaviour {

	public GameObject triggerText;
	public bool enteredTrigger = false;
	public LevelLoader levelLoader;

	void Start () {
		levelLoader = FindObjectOfType<LevelLoader>();
	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.E) && enteredTrigger == true)
		{
			levelLoader.OnFadeComplete();
		}
	}
	void OnTriggerEnter () {
		enteredTrigger = true;
		triggerText.SetActive(true);
	}
	void OnTriggerExit () {
		triggerText.SetActive(false);
	}
}