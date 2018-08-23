using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTutCtrl : MonoBehaviour {

	private Renderer rend;

	public bool activated;

	void Start(){
		rend = GetComponent<Renderer> ();
		//ct1 = GameObject.GetComponent<CompleteTask1> ();
		activated = false;
	}

	void Update(){
		
	}

	void OnTriggerEnter2D (Collider2D other)
	{
		if ((other.gameObject.tag == "Player")  && (rend.material.color != Color.green)) {
			rend.material.color = Color.green;
			activated = true;
		}
	}

	public bool getActive(){
		return activated;
	}
}
