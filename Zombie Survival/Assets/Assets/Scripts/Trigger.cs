using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public GameObject controller2;
	public GameObject controller3;
	public GameObject trigger;

	public GameObject boss;
	//bool activated;

	public void Start(){
		//activated = false;
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player" ) {
			if(trigger.transform.parent == controller2.transform){
				controller2.gameObject.GetComponent<A2Controller> ().setTrigger (trigger);
			}
			if(trigger.transform.parent == controller3.transform){
				controller3.gameObject.GetComponent<A3Controller> ().setTrigger (trigger);
				//if(activated == false){
					//activated = true;
					//boss 
				//}
			}
		}
	}
}
