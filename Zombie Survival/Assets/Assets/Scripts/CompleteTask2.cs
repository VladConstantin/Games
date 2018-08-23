using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteTask2 : MonoBehaviour {

	public GameObject player;
	public GameObject controller2;
	public GameObject controller3;

	public void deactivateObject(){
		gameObject.SetActive (false);
	}

	public void activateObject(){
		gameObject.SetActive (true);
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
			if(player.gameObject.GetComponent<GunController>().getKey() > 0){
				player.gameObject.GetComponent<GunController> ().useKey(1);

				if(this.transform.parent == controller2.transform){
					controller2.gameObject.GetComponent<A2Controller> ().setSuprise ();
				}
				if(this.transform.parent == controller3.transform){
					controller3.gameObject.GetComponent<A3Controller> ().setSuprise ();
				}
				deactivateObject ();
			}
		}
	}
}
