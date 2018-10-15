using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

	public GameObject mainMenu, charGallery, charDesc, options, selectChap;
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
	}

	public void OnSelectChapter()
	{
		selectChap.SetActive(true);
		anim.SetBool("isOpen", true);
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
	}

	public void OnSelectCharGalleryExit()
	{
		anim.SetBool("isSelected", false);
	}

}