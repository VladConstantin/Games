using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win : MonoBehaviour {
	public Text victory;

	public bool win;

	void Start () {
		
		win = false;	
	}

	void Update () {
		if (win == true) {
			victory.text = "You Survived";
		}
	}
	public void setWin(bool w){
		win = w;
	}
}
