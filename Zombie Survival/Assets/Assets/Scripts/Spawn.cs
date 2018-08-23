using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {
	float timer;



	public GameObject spawnZ(Transform spawnValues, GameObject zombType, float t)
	{
		timer = t;
	
		Vector3 spawnPosition = new Vector3 (spawnValues.position.x, spawnValues.position.y, 0);
		Quaternion spawnRotation = Quaternion.identity;
		GameObject z = Instantiate (zombType, spawnPosition, spawnRotation);
		return z;
	}


}
