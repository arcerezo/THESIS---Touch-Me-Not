using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class textTestMovement : MonoBehaviour {

public Text textTest;
	// Use this for initialization
	void Start () {
		textTest.text = " ";
		
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void moveRight (){
		textTest.text = "Moving to Right";
	}

	public void moveLeftt (){
		textTest.text = "Moving to Left";
	}

	public void moveForward (){
		textTest.text = "Moving Forward";
	}

	public void moveBack(){
		textTest.text = "Moving Backward";
	}
}
