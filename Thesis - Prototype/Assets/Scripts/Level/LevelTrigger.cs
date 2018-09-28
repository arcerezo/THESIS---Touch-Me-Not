using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTrigger : MonoBehaviour {
	public GameObject UIText;
	public string sceneIndex;
	public Scene scene;

	// void Awake () 
	// {
	// 	DontDestroyOnLoad(this.gameObject);
	// }

	void Start ()
	{
		sceneIndex = SceneManager.GetActiveScene().name;
		
		Debug.Log(sceneIndex);
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.E) && UIText.activeInHierarchy)
			{
			// 	if (sceneIndex == "Tiago's House")
			// 	{
			// 		SceneManager.LoadScene("World");
			// 	}
			// 	else if(sceneIndex == "World")
			// 	{
			// 		SceneManager.LoadScene("Tiago's House");
			// 	}
			// }
			if (sceneIndex == "Tiago's House")
				{
					SceneManager.LoadScene("World");
				    sceneIndex = "World";
				}
				else if(sceneIndex == "World")
				{
					SceneManager.LoadScene("Tiago's House");
					sceneIndex = "Tiago's House";
				}
			}
	}
	void OnTriggerEnter (Collider coll) {
		if (coll.gameObject.tag == "Player")
		{
			UIText.SetActive(true);
		}
	}

	// void LoadLastScene () 
	// {
	// 	SceneManager.LoadScene("Tiago's House");
	// }
	
	void OnTriggerExit ()
	{
		UIText.SetActive(false);
	}

	// void LoadNextScene ()
	// {
	// 	SceneManager.LoadScene("World");
		
	// }
}
