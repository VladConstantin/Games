using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenChest : MonoBehaviour {

	private Renderer rend;

	public GameObject player;


	public int amoPistol;
	public int amoAK;
	public int amoSG;
	public int healthRegained;
	public int key;
	public Text updateText;

	public bool opened;

	void Start(){
		rend = GetComponent<Renderer> ();
		opened = false;
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		
		if ((other.gameObject.tag == "Player") && opened == false) {	
			open ();
			opened = true;

		}
	}

	void open(){
		rend.material.color = new Color(0,0,0,0);
		player.gameObject.GetComponent<GunController> ().addAmo (amoPistol, amoAK, amoSG);
		player.gameObject.GetComponent<PlayerHealth> ().HealPlayer (healthRegained);
		player.gameObject.GetComponent<GunController> ().addKey (key);
		displayPickUp ();
	}
	void displayPickUp(){
		updateText.text = "Collected:\n";
		if (amoPistol > 0) {
			updateText.text +=	"<color=yellow>Pistol ammo(" + amoPistol.ToString () + ")</color>\n"; 
		}
		if (amoAK > 0) {
			updateText.text +=	"<color=yellow>AK47 ammo(" + amoAK.ToString () + ")</color>\n"; 
		}
		if (amoSG > 0) {
			updateText.text +=	"<color=yellow>Shotgun ammo(" + amoSG.ToString () + ")</color>\n"; 
		}
		if (healthRegained > 0) {
			updateText.text +=	"<color=red>Health(" + healthRegained.ToString () + ")</color>\n";
		
		}
		if (key > 0) {
			updateText.text +=	"<color=green>Key ("+ key.ToString ()+ ")</color>\n";
		}
		//if (pillz == true) {
		//	updateText.text +=	"The Antidote\n";
		//
		//}

	}
}
