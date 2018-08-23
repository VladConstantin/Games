using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A1Controller : MonoBehaviour 
{
	public GameObject spawner;

	//public GameObject ct1;
	public CompleteTask1 ct1;

	public ActivateTutCtrl left;
	public ActivateTutCtrl right;
	public ActivateTutCtrl up;
	public ActivateTutCtrl down;
	public ActivateTutCtrlShoot shoot;

	public GameObject ZombieNormal;
	public GameObject ZombieFast;
	public GameObject ZombieFat;

	bool complete;

	void Start(){
		complete = false;
	}
	void Update () {
		if (left.getActive() && right.getActive() && down.getActive() && up.getActive() && shoot.getActive() && complete == false) {
			//ct1.gameObject.GetComponent<CompleteTask1>().deactivateObject();
			ct1.deactivateObject();
			complete = true;
		}
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			spawner.gameObject.GetComponent<Spawn> ().spawnZ(spawner.transform, ZombieNormal, 0.0f);
			//ct1.gameObject.GetComponent<CompleteTask1>().activateObject ();
			ct1.activateObject();
			gameObject.SetActive (false);
		}
	}
}
