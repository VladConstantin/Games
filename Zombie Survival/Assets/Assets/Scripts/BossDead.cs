using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BossDead : MonoBehaviour {

	public GameObject boss;

	void Update () {
		if (boss.gameObject.GetComponent<ZombieHealth>().getHealth () <= 0) {
			
		}
	}
}
