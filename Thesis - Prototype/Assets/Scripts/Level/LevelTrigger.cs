using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour {

	public GameObject triggerText;
	public bool enteredTrigger = false;
	public LevelLoader levelLoader;
	public GameObject doorTrigger;
	public bool insideBuilding = false;

	void Start () {
		levelLoader = FindObjectOfType<LevelLoader>();
		GameObject.Find("Player").transform.position = doorTrigger.transform.position;
	}

	void Awake () {
		DontDestroyOnLoad(this.gameObject);
	}

	void Update () {
		if (Input.GetKeyDown(KeyCode.E) && enteredTrigger == true)
		{
			insideBuilding = true;
			levelLoader.OnFadeComplete();
		} 
			else if (Input.GetKeyDown(KeyCode.E) && enteredTrigger == true && insideBuilding == true)
			{
				levelLoader.LoadPreviousScene();
			}
	}
	void OnTriggerEnter () {
		enteredTrigger = true;
		triggerText.SetActive(true);
	}
	void OnTriggerExit () {
		enteredTrigger = false;
		triggerText.SetActive(false);
	}
}