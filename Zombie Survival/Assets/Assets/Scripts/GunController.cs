using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunController : MonoBehaviour {

	public bool isFiring;

	public int key;

	public int gunType;

	public bulletMovement bullet;
	public float bulletSpeed;

	public int gunDMG;

	public float timeBetweenShots;
	public float shotCounter;

	public Transform fpPistol;
	public Transform fpAK;
	public Transform fpSG1;
	public Transform fpSG2;
	public Transform fpSG3;
	public Transform fpSG4;
	public Transform fpSG5;

	public GameObject AK;
	public GameObject SG;
	public GameObject P;

	public Text PistolAmo;
	public Text AKAmo;
	public Text SGAmo;

	public int bulletPistol;
	public int bulletAK;
	public int bulletSG;


	void Start () {
		gunType = 1;
		bulletPistol = 50;
		bulletAK = 0;
		bulletSG = 0;
		timeBetweenShots = 0.5f;
		gunDMG = 5;
		gunType = 1;
		AK.gameObject.SetActive (false);
		SG.gameObject.SetActive (false);
		P.gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		PistolAmo.text = bulletPistol.ToString();
		AKAmo.text = bulletAK.ToString();
		SGAmo.text = bulletSG.ToString();
		 

		if (Input.GetKeyDown ("1")) {
			timeBetweenShots = 0.5f;
			gunDMG = 5;
			gunType = 1;
			P.gameObject.SetActive (true);
			AK.gameObject.SetActive (false);
			SG.gameObject.SetActive (false);
		} 
		if (Input.GetKeyDown ("2")) {
			timeBetweenShots = 0.05f;
			gunDMG = 1;
			gunType = 2;
			P.gameObject.SetActive (false);
			AK.gameObject.SetActive (true);
			SG.gameObject.SetActive (false);
		}
		if (Input.GetKeyDown ("3")) {
			timeBetweenShots = 2f;
			gunDMG = 4;
			gunType = 3;
			P.gameObject.SetActive (false);
			AK.gameObject.SetActive (false);
			SG.gameObject.SetActive (true);
		}
			
		switch (gunType)
		{
		case 1:
			ShootPistol();
		break;
		case 2:
			ShootAK();
			break;
		case 3:
			ShootSG();
			break;
		default:
			P.gameObject.SetActive (true);
			AK.gameObject.SetActive (false);
			SG.gameObject.SetActive (false);
			break;
		}

	}
		
	public void addAmo(int Pistol, int AK, int SG){
		bulletPistol += Pistol;
		bulletAK += AK;
		bulletSG += SG;
	}

	public void addKey(int k){
		key += k;
	}
	public void useKey(int k){
		key -= k;
	}

	public int getKey(){
		return key;
	}
	public void ShootPistol(){
		if (bulletPistol != 0) {
			shotCounter -= Time.deltaTime;
			if (isFiring) {				
				if (shotCounter <= 0) {
					bulletPistol -= 1;
					shotCounter = timeBetweenShots;
					bulletMovement newBullet = Instantiate (bullet, fpPistol.position, fpPistol.rotation) as bulletMovement;
					newBullet.damageToGive = gunDMG;
					newBullet.speed = bulletSpeed;
				}
			}
		}
	}

	public void ShootAK(){
		if (bulletAK != 0) {
			shotCounter -= Time.deltaTime;
			if (isFiring) {							
				if (shotCounter <= 0) {
					bulletAK -= 1;
					shotCounter = timeBetweenShots;
					bulletMovement newBullet = Instantiate (bullet, fpAK.position, fpAK.rotation) as bulletMovement;
					newBullet.damageToGive = gunDMG;
					newBullet.speed = bulletSpeed;
				}
			}
		}
	}

	public void ShootSG(){
		if (bulletSG > 4) {
			shotCounter -= Time.deltaTime;
			if (isFiring) {							 
				if (shotCounter <= 0) {
					bulletSG -= 5;
					shotCounter = timeBetweenShots;
					//for(bulletMovement newBullet1 = Instantiate (bullet, fpSG (i) .position, fpSG1.rotation) as bulletMovement;)
					bulletMovement newBullet1 = Instantiate (bullet, fpSG1.position, fpSG1.rotation) as bulletMovement;
					bulletMovement newBullet2 = Instantiate (bullet, fpSG2.position, fpSG2.rotation) as bulletMovement;
					bulletMovement newBullet3 = Instantiate (bullet, fpSG3.position, fpSG3.rotation) as bulletMovement;
					bulletMovement newBullet4 = Instantiate (bullet, fpSG4.position, fpSG4.rotation) as bulletMovement;
					bulletMovement newBullet5 = Instantiate (bullet, fpSG5.position, fpSG5.rotation) as bulletMovement;
					newBullet1.damageToGive = gunDMG;
					newBullet1.speed = bulletSpeed;
					newBullet2.damageToGive = gunDMG;
					newBullet2.speed = bulletSpeed;
					newBullet3.damageToGive = gunDMG;
					newBullet3.speed = bulletSpeed;
					newBullet4.damageToGive = gunDMG;
					newBullet4.speed = bulletSpeed;
					newBullet5.damageToGive = gunDMG;
					newBullet5.speed = bulletSpeed;
				}
			}
		}
	}

}