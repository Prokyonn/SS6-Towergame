using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {

	public Transform crosshair; 
	public GameObject bullet;

	private SteamVR_TrackedController controller;

	// Use this for initialization
	void Start () 
	{
	
		controller = GetComponent<SteamVR_TrackedController> ();
		controller.TriggerClicked += FireWeapon;
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	private void FireWeapon(object sender, ClickedEventArgs e)
	{
		if (bullet) 
		{
			GameObject newBullet = Instantiate (bullet, crosshair.gameObject.transform.position, transform.rotation) as GameObject;
			newBullet.GetComponent<Rigidbody> ().AddForce (transform.forward * 20f, ForceMode.VelocityChange);
		}


	}

}
