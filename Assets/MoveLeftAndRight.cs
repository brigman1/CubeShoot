using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftAndRight : MonoBehaviour 
{
	public float speed = 50.0f;



	// Use this for initialization
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () 
	{
		//input.GetAxis == gets a keyboard input for axis
		transform.position += Vector3.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime;
		//moves object left or right based on axis, speed, and time
	}
}
