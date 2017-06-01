using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoldingItTogether : MonoBehaviour {

	GameObject body;

	// Use this for initialization
	void Start () {
		body = GameObject.FindGameObjectWithTag("SlimeHead");
	}
	
	// Update is called once per frame
	void Update () {

	//	int len = body.Length;
	//	float curr=0;

	//	for(int i = 0;i<len;i++)
	//	{
	//		GameObject place;
	//		place = body[i];
	//		Vector2 holder = place.transform.position;
	//		curr = curr + holder.x;
	//	}

	//	float avg;

	//	avg = curr/len;

		GetComponent<Rigidbody2D>().position = Vector2.MoveTowards(GetComponent<Rigidbody2D>().position, body.transform.position, .01f);
		
	}
}
