using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteTask1 : MonoBehaviour {

	public GameObject barier;

	public void deactivateObject(){
		barier.gameObject.SetActive (false);
	}

	public void activateObject(){
		barier.gameObject.SetActive (true);
	}
}
