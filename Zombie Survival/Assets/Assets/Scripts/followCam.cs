using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCam : MonoBehaviour {

	float Damping = 8.0f;
	public Transform Player;
	float Height  = 0.0f;
	float Height2  = 0.0f;
	float Offset  = 0.0f;
	private Vector3 Center;
	float ViewDistance  = -5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

			var mousePos = Input.mousePosition;
			mousePos.z = ViewDistance;
			Vector3 CursorPosition = Camera.main.ScreenToWorldPoint(mousePos);

			var PlayerPosition = Player.position;

		Center = new Vector3((PlayerPosition.x + CursorPosition.x) / 2, (PlayerPosition.y + CursorPosition.y) / 2, ViewDistance);

			transform.position = Vector3.Lerp(transform.position, Center + new Vector3(Height2,Height,Offset), Time.deltaTime * Damping); 
	}
}
  