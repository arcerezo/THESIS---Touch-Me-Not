using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

	public Animator animator;

	public int levelToLoad;

	public void FadeToLevel (int levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
		SceneManager.LoadSceneAsync(levelToLoad);
	}
}