using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int StartHealth;
	public int currentHealth;
	public Slider hSlider;
	public Image dmgImg;
	public Image WinImg;
	public Image KeyImg;
	public AudioClip deathCliip;
	public float flashSpeed = 0.1f;

	AudioSource playerAudio;

	public GameObject gameOver;
	bool damaged;
	bool healed;

	public Text dead;

	public Color hurtFlashColor = new Color(1f, 0f, 0f, 0.1f);
	public Color healFlashColor = new Color(0f, 1f, 0f, 0.1f);

	//public float timeBetweenDmg;
	//private float dmgCounter;

	void Awake(){
		//anim = GetComponent<Animator> (); 
		playerAudio = GetComponent <AudioSource> ();
		currentHealth = StartHealth;
	}

	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0) {
			Death();
		}

		if (currentHealth >= 100) {
			currentHealth = 100;
		}

		if (healed) {
			dmgImg.color = healFlashColor;
		} else {
			dmgImg.color = Color.Lerp (dmgImg.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		healed = false;

		if (damaged) {
			dmgImg.color = hurtFlashColor;
		} else {
			dmgImg.color = Color.Lerp (dmgImg.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	
	}

	public void HealPlayer(int Health){
		healed = true;
		//playerAudio.Play();
		currentHealth += Health;
		hSlider.value = currentHealth;
	}

	public void HurtPlayer(int dmg){
		damaged = true;
		//playerAudio.Play ();
		currentHealth -= dmg;
		hSlider.value = currentHealth;
		//disease = true;
	}

	public void Death(){
		dmgImg.color = hurtFlashColor;
		dead.text = "You Died";
		gameOver.GetComponent<gameOver>().setGameEnd(1);
		gameObject.SetActive (false);

		//anim.SetTrigger ("die");
		//playerAudio.clip = deathClip;
		//playerAudio.Play ();
		//playerMobility.enabled = false;
		//playerShooting.enabled = false;
	}

	public void setWin(){
		gameOver.GetComponent<gameOver>().setGameEnd(2);
		dead.text = "You Survived";
		WinImg.color = healFlashColor;

	}
}


