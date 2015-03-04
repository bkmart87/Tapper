using UnityEngine;
using System.Collections;

public class SpawnDrink : MonoBehaviour 
{
	private float chargeLevel;
	private bool isCharging; 
	private bool haveAMug;
	public GameObject beerPrefab;
	public Transform spawnPoint; 

	

	void Start () 
{

		haveAMug = false;
}
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Space) && !isCharging)
			{
			Debug.Log ("GetButtonDown Charging");
			isCharging = true;
			}
		/* Could not figure out how to charge this with out having the game crash, ask Margaret. */
		if (isCharging == true && !haveAMug)
		{
			for (int i=0; i <30000; i++)
			{
				isCharging = false;
				haveAMug = true;
			}
			Instantiate (beerPrefab, spawnPoint.position, Quaternion.identity);
			Debug.Log ("Fired NotCharging");
		}

		if (Input.GetKeyUp (KeyCode.Space))
			{
				Debug.Log ("GetButtonUp NotCharging");
			isCharging = false;
			haveAMug = false;
			}
	}

}
