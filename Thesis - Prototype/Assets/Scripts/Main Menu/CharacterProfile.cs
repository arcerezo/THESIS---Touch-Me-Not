using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterProfile : MonoBehaviour {

	public string charName;

	[TextArea(3, 10)]
	public string description;
	public CharacterProfile charProfile;
	public DescriptionHandler descHandler;
	public Sprite charSprite;
	
	public void OnButtonClick()
	{
		descHandler.nameTxt.text = charName;
		descHandler.descTxt.text = description;
		descHandler.charImage.sprite = charSprite;
	}
}
