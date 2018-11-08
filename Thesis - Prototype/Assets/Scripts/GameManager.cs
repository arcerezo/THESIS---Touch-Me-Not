using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	private static GameManager _instance;
	public GameObject pauseUI;
	
	public static GameManager Instance
	{
		get
		{

			if (_instance == null)
			{
				GameObject go = new GameObject("Game Manager");
				go.AddComponent<GameManager>();
			}
			return _instance;
		}
	}

	public GameObject item {get; set;}
	void Awake ()
	{
		_instance = this;
	}

	public void GoToMM()
	{
		SceneManager.LoadScene("Main Menu");
	}
	public void ExitGame()
	{
		Application.Quit();
	}
	public void ContinueGame()
	{
		Time.timeScale = 1;
			
		pauseUI.SetActive(false);
	}

	public void PauseGame()
	{
		if(Time.timeScale == 1)
		{
			Time.timeScale = 0;
			
			pauseUI.SetActive(true);
		}
		else{
			Time.timeScale = 1;
			
			pauseUI.SetActive(false);
		}
	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			PauseGame();
		}
	}
}