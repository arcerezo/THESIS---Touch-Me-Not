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
						else if(sceneIndex == "Chapter2_1")
						{
							SceneManager.LoadScene("Chapter2_2");
							sceneIndex = "Chapter2_2";
						}
							else if(sceneIndex == "Chapter2_3")
							{
								SceneManager.LoadScene("Chapter2_4");
								sceneIndex = "Chapter2_4";
							}
								else if(sceneIndex == "Chapter2_4")
								{
									SceneManager.LoadScene("Chapter3_1");
									sceneIndex = "Chapter3_1";
								}
									else if(sceneIndex == "Chapter3_1")
									{
										SceneManager.LoadScene("Chapter3_2");
										sceneIndex = "Chapter3_2";
									}
										else if(sceneIndex == "Chapter3_2")
										{
											SceneManager.LoadScene("Chapter3_3");
											sceneIndex = "Chapter3_3";
										}
											else if(sceneIndex == "Chapter3_4")
											{
												SceneManager.LoadScene("Chapter3_5");
												sceneIndex = "Chapter3_5";
											}
												else if(sceneIndex == "Chapter4_2")
												{
													SceneManager.LoadScene("Chapter4_3");
													sceneIndex = "Chapter4_3";
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
