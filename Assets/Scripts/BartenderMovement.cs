using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BartenderMovement : MonoBehaviour 
{

	public Transform[] aisleArray; 
	int totalIndex; 
	int currentAisleIndex = 1;
	int currentAisle;
	
	public Vector2 xSpeed = new Vector2(-100, 0);


	void Start () 
	{
	totalIndex = aisleArray.Length;
	totalIndex -= 1;
	}
	
	void Update ()
	{
		if (Input.GetAxisRaw ("Vertical") != 0)
		{
			Teleport();
		}
	}

	void FixedUpdate () 
	{

		if (Input.GetAxisRaw ("Horizontal") < 0)
		{
			rigidbody2D.MovePosition(rigidbody2D.position + xSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3(0,360 ,0);
		}
		if (Input.GetAxisRaw ("Horizontal") > 0)
		{
			rigidbody2D.MovePosition(rigidbody2D.position - xSpeed * Time.deltaTime);
			transform.eulerAngles = new Vector3(0,180 ,0); 
		}
		
	}
	//		float vert = Input.GetAxisRaw ("Vertical");
	/* Comment: Loop over 1 through total positions. 
		 I doesn't include the Zeroth element to avoid array out of range issue */
	void Teleport() 
	{
		if (Input.GetKeyDown (KeyCode.DownArrow))
		{
			currentAisleIndex += 1;
		}
		
		if (Input.GetKeyDown (KeyCode.UpArrow) )
		{
			currentAisleIndex -= 1;
		}
		if (currentAisleIndex <= 0)
		{
			currentAisleIndex = totalIndex;
		}
		else if (currentAisleIndex > totalIndex)
		{
			currentAisleIndex = 1;
		}
		transform.position = aisleArray[currentAisleIndex].position;
		
		//		currentAisleIndex = keysPressed % totalIndex;
		print (currentAisleIndex);
		/*		Comment: makes it move to the point */

	}
}
