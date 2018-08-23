using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A2Controller : MonoBehaviour {

	public GameObject spawner1;
	public GameObject spawner2;
	public GameObject spawner3;
	public GameObject spawner4;
	public GameObject spawner5;
	public GameObject spawner6;

	public bool t1;
	public bool t2;
	public bool suprise = false;

	public GameObject trigger1;
	public GameObject trigger2;
	public GameObject trigger3;

	public GameObject ZombieNormal;
	public GameObject ZombieFast;
	public GameObject ZombieFat;

	GameObject z1;
	GameObject z2;
	GameObject z3;
	GameObject z4;
	GameObject z5;
	// Use this for initialization

	public void setTrigger (GameObject go){
		if (trigger1 == go) {
			t1 = true;
		}
		if (trigger2 == go) {
			t2 = true;
		}

	}

	public void setSuprise(){
		suprise = true;
	}

	void Update () {
		if(t1){
			spawner1.gameObject.GetComponent<Spawn> ().spawnZ (spawner1.transform, ZombieNormal,0.0f);
			spawner2.gameObject.GetComponent<Spawn> ().spawnZ (spawner2.transform, ZombieNormal,0.0f);
			spawner3.gameObject.GetComponent<Spawn> ().spawnZ (spawner3.transform, ZombieNormal,0.0f);
			t1 = false;
			trigger1.gameObject.SetActive(false);
		}

		if(t2){
			spawner4.gameObject.GetComponent<Spawn> ().spawnZ (spawner4.transform, ZombieFat,0.0f);
			spawner5.gameObject.GetComponent<Spawn> ().spawnZ (spawner5.transform, ZombieFat,0.0f);
			t2 = false;
			trigger2.gameObject.SetActive(false);
		}

		if (suprise) {
			spawner6.gameObject.GetComponent<Spawn> ().spawnZ (spawner6.transform, ZombieFast,0.0f);
			spawner6.gameObject.GetComponent<Spawn> ().spawnZ (spawner6.transform, ZombieFast,1.5f);
			suprise = false;
			trigger3.gameObject.SetActive(false);
		}
	}
}
