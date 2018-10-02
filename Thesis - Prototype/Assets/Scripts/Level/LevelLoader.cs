using UnityEngine;

public class LevelLoader : MonoBehaviour {

	public Animator animator;

	public void FadeToLevel ()
	{
		animator.SetTrigger("FadeOut");
	}
}