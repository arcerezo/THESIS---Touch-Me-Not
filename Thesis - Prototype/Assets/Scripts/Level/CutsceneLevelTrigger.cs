using UnityEngine;
using UnityEngine.SceneManagement;

public class CutsceneLevelTrigger : MonoBehaviour {
	
	public string sceneIndex;
	void Start ()
	{
		sceneIndex = SceneManager.GetActiveScene().name;
		
		Debug.Log(sceneIndex);
	}
	public void LoadNextScene ()
	{

		if  (sceneIndex == "CH_1") {
			SceneManager.LoadScene("Chapter2_1");
			sceneIndex = "Chapter2_1";
		}
		else if (sceneIndex == "Tiago's House")
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
					else if(sceneIndex == "Chapter2_2")
					{
						SceneManager.LoadScene("Chapter2_3");
						sceneIndex = "Chapter2_3";
					}
	}
}
