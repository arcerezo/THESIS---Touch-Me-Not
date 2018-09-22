using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public Animator animator;
	public int levelToLoad;
	int sceneIndex;

	void Start () {
		sceneIndex = SceneManager.GetActiveScene().buildIndex;
	}

	public void FadeToLevel()
	{
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
        SceneManager.LoadScene(sceneIndex + 1);
	}

	public void LoadPreviousScene () {
		SceneManager.LoadScene(sceneIndex - 1);
	}
}