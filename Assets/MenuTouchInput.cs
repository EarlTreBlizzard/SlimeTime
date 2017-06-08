//=========================================================
//Main Menu Touch Controls
//Creadted By: Aaron Blanchard
//Edited By:
//Description:  This segmentof code is for the Main Menu of
//SlimeTime, for the navigation through the menus.
//=========================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTouchInput : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
//=========================================================
		//testing touch controls
		if (Input.touchCount > 0) {

			if(Input.GetTouch(0).phase == TouchPhase.Began)
			{
				Debug.Log ("Touch Begins");
			}
			if(Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				Debug.Log ("Touch Moved");
			}
			if(Input.GetTouch(0).phase == TouchPhase.Ended)
			{
				Debug.Log ("Touch Ended");
			}
		}
//=========================================================
		//if ((Input.GetTouch(0).phase == TouchPhase.Began) && (Input.GetTouch(0).phase == TouchPhase.Ended))
			
	
	
	
	
	
	}
}
