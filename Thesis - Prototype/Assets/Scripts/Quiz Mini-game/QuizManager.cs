using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour {

	// private bool correctAns = false, wrongAns = false;
	// public Button corrButton;
	// public List<Button> wrongButtons;
	public GameObject corrPanel, wrongPanel;
	private Animator anim;
	// Use this for initialization
	void Start () {
		// Button[] wrongButtons = this.GetComponentsInChildren<Button>();
		// corrButton.onClick.AddListener(CorrectAnswer);
		// wrongButtons.onClick.AddListener(WrongAnswer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void CorrectAnswer()
	{
		corrPanel.SetActive(true);
	}
	public void WrongAnswer()
	{
		wrongPanel.SetActive(true);
	}
	public void Continue()
	{
		anim.Play("continue");
	}

	public void LoadNextScene(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}
}
