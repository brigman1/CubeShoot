using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public Vector3 direction = Vector3.forward;
	public float speed = 1.0f;

	// Use this for initialization
	void Start () 
	{
		//Moves the cube to the right with a (1,0,0) vector
		//transform.position += Vector3.right;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Time.deltaTime makes it run not based on frame rate
		//How much to do every second
		transform.position += transform.rotation*(direction.normalized*speed*Time.deltaTime);

		//normalized makes it a one unit vector
		//delta time == PER second
	}
}
