using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowSpeed : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerMobility>().slow(0.5f);
		}
		if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boss") {
			other.gameObject.GetComponent<ZombieMovement>().slow (0.5f);
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerMobility>().slow(2.0f);
		}
		if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Boss") {
			other.gameObject.GetComponent<ZombieMovement>().slow (2.0f);
		}
	}
}
