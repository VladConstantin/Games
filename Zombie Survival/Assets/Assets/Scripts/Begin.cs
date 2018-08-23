using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour {

	public Transform itself;
	public GameObject eG;
	// Use this for initialization
	void Start () {
		Instantiate (eG,itself.position, itself.rotation);
	}

}
