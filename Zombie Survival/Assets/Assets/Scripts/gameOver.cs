using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class gameOver : MonoBehaviour {


	public float timeToMenu;

	public int gameEnd;

	public void Start(){
		gameEnd = 0;
	}

	public void changeToScene(int scene)
	{
		SceneManager.LoadScene (scene);
	}
	

	void Update () {
		if (gameEnd > 0) {
			timeToMenu -= Time.deltaTime;
			if(timeToMenu <= 0){
				changeToScene (0);
			}
		}
	}

	public void setGameEnd(int i){
		gameEnd = i;
	}
}
