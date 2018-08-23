using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTutCtrlShoot : MonoBehaviour {

	private Renderer rend;
	private SpriteRenderer sr;
	public CompleteTask1 ct1;

	public bool activated;

	void Start(){
		rend = GetComponent<Renderer> ();
		//ct1 = GameObject.GetComponent<CompleteTask1> ();
		 sr= GetComponent<SpriteRenderer> ();
		sr.color = Color.red;
		activated = false;
	}

	void Update(){
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if ((other.gameObject.tag == "Bullet")  && (rend.material.color != Color.green)) {
			sr.color = Color.green;
			activated = true;
			//ct1.addY ();
		}
	}
	public bool getActive(){
		return activated;
	}
}
