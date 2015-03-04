using UnityEngine;
using System.Collections;

public class Beer : MonoBehaviour 
{
	Vector3 movingTarget;
	public int endOfScreen;

	void Start () 
	{
	

	}

	void Update () 
	{
		movingTarget = transform.position;
		movingTarget = movingTarget + new Vector3 (-.1f, 0f, 0f);
		rigidbody2D.MovePosition (movingTarget);
	}
	void OnCollisionEnter2D (Collision2D coll) 
	{
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.tag == "Cowboy")
		{

//			WaitForSeconds(0.1f);
//			count ++;
//			SetCountText ();
			Destroy(collidedWith);
			Destroy(this.gameObject);
		}
		if (collidedWith.tag == "Wall")
		{
			//			WaitForSeconds(0.1f);
			//			count ++;
			//			SetCountText ();
			Destroy(this.gameObject);
		}
		
		
	}
}
