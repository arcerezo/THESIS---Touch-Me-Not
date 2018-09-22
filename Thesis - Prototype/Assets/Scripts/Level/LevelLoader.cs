using UnityEngine;

public class LevelLoader : MonoBehaviour {

	public Animator animator;
	public Transform spawnpoint;

	void Start ()
	{
		GameObject.Find("Player").transform.position = spawnpoint.transform.position;
	}

	public void FadeToLevel ()
	{
		animator.SetTrigger("FadeOut");
	}
}