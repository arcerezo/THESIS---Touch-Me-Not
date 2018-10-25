using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	public GameObject mainMenu, charGallery, charDesc, options, selectChap, fs, cont, vol, abt;
	public Animator anim;

	void Start()
	{
		charGallery.SetActive(false);
		charDesc.SetActive(false);
	}

	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene (sceneIndex);
	}

	public void OnCharGallery()
	{
		anim.SetBool("isOpen", true);
		charGallery.SetActive(true);

		mainMenu.SetActive(false);
	}

	public void OnOptions()
	{
		options.SetActive(true);
		anim.SetBool("isOpen", true);
		
		mainMenu.SetActive(false);
	}

	public void OnSelectChapter()
	{
		selectChap.SetActive(true);
		anim.SetBool("isOpen", true);
		
		mainMenu.SetActive(false);
	}

	public void OnBackToMainMenu()
	{
		anim.SetBool("isOpen", false);
		charGallery.SetActive(false);
		charDesc.SetActive(false);
		options.SetActive(false);
		selectChap.SetActive(false);
		mainMenu.SetActive(true);
	}

	public void OnSelectCharGallery()
	{
		anim.SetBool("isSelected", true);
		charDesc.SetActive(true);
		
		mainMenu.SetActive(false);
	}

	public void OnSelectCharGalleryExit()
	{
		anim.SetBool("isSelected", false);
	}

	public void QuitGame()
	{
		Application.Quit();
	}

	public void OptionsFullscreen()
	{
		fs.SetActive(true);
		cont.SetActive(false);
		vol.SetActive(false);
		abt.SetActive(false);
	}

	public void OptionsControl()
	{
		cont.SetActive(true);
		fs.SetActive(false);
		vol.SetActive(false);
		abt.SetActive(false);
	}

	public void OptionsVolume()
	{
		vol.SetActive(true);
		fs.SetActive(false);
		abt.SetActive(false);
		cont.SetActive(false);
	}

	public void OptionsAbout()
	{
		abt.SetActive(true);
		vol.SetActive(false);
		fs.SetActive(false);
		cont.SetActive(false);
	}
}