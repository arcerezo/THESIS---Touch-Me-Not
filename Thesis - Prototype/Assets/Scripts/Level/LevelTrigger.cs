using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour {
	public GameObject UIText;
	public int sceneIndex;

	void Awake () 
	{
		DontDestroyOnLoad(this.gameObject);
	}
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.E) && UIText.activeInHierarchy)
			{
				LoadNextScene();
			}
	}
	void OnTriggerEnter (Collider coll) {
		if (coll.gameObject.tag == "Player")
		{
			UIText.SetActive(true);
		}
	}
	
	void OnTriggerExit ()
	{
		UIText.SetActive(false);
	}

	void LoadNextScene ()
	{
		SceneManager.LoadScene(sceneIndex);
	}
}
