using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

	public int dmgGiven;
	private bool stillTouching = false;
	public float timeBetweenHits;
	GameObject player;
	float hitCounter;

	void Start(){
		hitCounter = 0.0f;
	}
	void Update(){
		hitCounter -= Time.deltaTime;
		if (stillTouching == true && hitCounter <= 0) {
			hitCounter = timeBetweenHits;
			player.gameObject.GetComponent<PlayerHealth> ().HurtPlayer (dmgGiven);
		}


	}
	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			stillTouching = true;
			player = other.gameObject;
		}

	}
	void OnTriggerExit2D (Collider2D other)
	{
		if (other.gameObject.tag == "Player") {
			stillTouching = false;
		}

	}
	public float getHitCounter(){
		return hitCounter;
	}
}
