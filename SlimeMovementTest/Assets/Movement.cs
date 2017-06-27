//Author: Joshua Bevell
//
//Movement.cs controls the movement of the slime across platforms. All controls will be 
//included here.

using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 5.0f;
//	private RigidBody2D slimephysics	//Keeps the slime from flying for right now
	
	void Start()
	{
		Input.multiTouchEnabled = true;
	}
	
	void Update()
	{
		//Debug.Log(Input.touchCount);
		if(Input.touchCount > 0)
		{
			Vector2 movepos = Camera.main.ScreenToWorldPoint(new Vector2(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y));
			Debug.Log(movepos);
			
			this.gameObject.transform.Translate(Vector3.MoveTowards(this.gameObject.transform.position, movepos, speed * Time.deltaTime) - this.gameObject.transform.position);
			
			/*foreach(Touch touch in Input.touches)
			{
				//Debug.Log(touch.position);
				
				if (Input.GetTouch(0).phase == TouchPhase.Began)
				{
					Debug.Log("Touch Began");
				}
				if (Input.GetTouch(0).phase == TouchPhase.Moved)
				{
					Debug.Log("Touch Moved");
				}
				if (Input.GetTouch(0).phase == TouchPhase.Ended)
				{
					Debug.Log("Touch Ended");
				}
			}*/
		}
	}
}

