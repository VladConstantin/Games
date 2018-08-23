using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMobility : MonoBehaviour {

	public float speed;
	Transform playerT;
	Rigidbody2D rb;
	Camera cam;
	public GunController gun;

	void Start(){
		//animation = GetComponent<Animator> ();
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			gun.isFiring = true;
		}

		if (Input.GetMouseButtonUp (0)) {
			gun.isFiring = false;
		}
	}

	void Awake()
	{
		cam = Camera.main;
		playerT = GetComponent <Transform> ();
		rb = GetComponent <Rigidbody2D> ();
	}
		
	void FixedUpdate()
	{
		// ====== ROTATION =====
		float camDis = cam.transform.position.y - playerT.position.y;

		Vector3 mouse = cam.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, camDis));

		float AngleRad = Mathf.Atan2 (mouse.y - playerT.position.y, mouse.x - playerT.position.x);
		float angle = (180 / Mathf.PI) * AngleRad;

		rb.rotation = angle;

		// ===== MOVEMENT =====

		var direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += Vector3.ClampMagnitude(direction, 0.7f ) * speed * Time.deltaTime;

		if(Input.GetMouseButtonDown(0)){
		//	anim.setTrigger("attack")
		}
	}

	public void slow(float f){
		speed *= f;
	}
}
