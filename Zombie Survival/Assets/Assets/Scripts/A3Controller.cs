using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3Controller : MonoBehaviour {

	public GameObject spawner1;
	public GameObject spawner2;
	public GameObject spawner3;
	public GameObject spawner4;
	public GameObject spawner5;
	public GameObject spawner6;
	public GameObject bossSpawner;

	public bool t1;
	public bool t2;
	public bool t3;
	public bool t4;
	public bool boss;

	public bool suprise = false;

	public GameObject trigger1;
	public GameObject trigger2;
	public GameObject trigger3;
	public GameObject trigger4;
	public GameObject bossTrigger;

	public GameObject ZombieNormal;
	public GameObject ZombieFast;
	public GameObject ZombieFat;
	public GameObject ZombieBoss;
	public GameObject Player;
	public GameObject cA3;
	GameObject b;
	public GameObject gO;
	void Start(){
		//ZombieBoss.gameObject.GetComponent<ZombieMovement>().slow(0.0f);
	}

	public void setTrigger (GameObject go){
		if (trigger1 == go) {
			t1 = true;
		}
		if (trigger2 == go) {
			t2 = true;
		}
		if (trigger3 == go) {
			t3 = true;
		}
		if (trigger4 == go) {
			t4 = true;
		}
		if (bossTrigger == go) {
			boss = true;		
		}

	}
		

	void Update () {
		if(t1){
			spawner1.gameObject.GetComponent<Spawn> ().spawnZ (spawner1.transform, ZombieNormal,0.0f);
			t1 = false;
			trigger1.gameObject.SetActive(false);
		}

		if(t2){
			spawner2.gameObject.GetComponent<Spawn> ().spawnZ (spawner2.transform, ZombieFast,0.0f);
			spawner2.gameObject.GetComponent<Spawn> ().spawnZ (spawner2.transform, ZombieFast,0.0f);
			spawner2.gameObject.GetComponent<Spawn> ().spawnZ (spawner2.transform, ZombieFast,0.0f);
			t2 = false;
			trigger2.gameObject.SetActive(false);
		}

		if (t3) {
			spawner3.gameObject.GetComponent<Spawn> ().spawnZ (spawner3.transform, ZombieNormal,0.0f);
			spawner4.gameObject.GetComponent<Spawn> ().spawnZ (spawner4.transform, ZombieFast,0.0f);
			spawner4.gameObject.GetComponent<Spawn> ().spawnZ (spawner4.transform, ZombieFast,0.0f);
			spawner5.gameObject.GetComponent<Spawn> ().spawnZ (spawner5.transform, ZombieFat,0.0f);
			t3 = false;
			trigger3.gameObject.SetActive(false);
		}

		if (t4) {
			spawner6.gameObject.GetComponent<Spawn> ().spawnZ (spawner6.transform, ZombieFat,0.0f);
			t4 = false;
			trigger4.gameObject.SetActive(false);
		}

		if (boss) {
			cA3.gameObject.GetComponent<CompleteTask2>().activateObject();	
			b = bossSpawner.gameObject.GetComponent<Spawn> ().spawnZ (bossSpawner.transform, ZombieBoss,0.0f);
			boss = false;

			bossTrigger.gameObject.SetActive(false);
			ZombieBoss.gameObject.GetComponent<ZombieMovement>().setSpeed(3f);
		}

		if (b.gameObject.GetComponent<ZombieHealth> ().getHealth() <= 0) {
			Player.gameObject.GetComponent<PlayerHealth> ().setWin();
			gO.GetComponent<gameOver> ().setGameEnd (2);
		}
	}

	public void setSuprise(){
		suprise = true;
	}
}
