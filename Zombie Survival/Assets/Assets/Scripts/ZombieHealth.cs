using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZombieHealth : MonoBehaviour {

	public int health;
	public int currentHealth;
	//public bool bossDead = false;
	void Start () {
		currentHealth = health;
	}

	void Update () {
		if (currentHealth <= 0) {
			Destroy (this.gameObject);
		}
	}

	public void HurtEnemy(int dmg){
		currentHealth = currentHealth - dmg;
	}

	public int getHealth(){
		return currentHealth;
	}
}
