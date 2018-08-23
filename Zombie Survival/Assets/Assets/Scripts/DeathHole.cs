﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHole : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.gameObject.tag == "Enemy") {
			Destroy (other.gameObject);
		}
		if(other.gameObject.tag == "Player"){
			other.gameObject.GetComponent <PlayerHealth>().Death();
		}

	}
}
