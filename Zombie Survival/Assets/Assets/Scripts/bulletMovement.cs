using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMovement : MonoBehaviour {

	Rigidbody2D rb;
	public float speed;
	public Vector3 bulletRotation;
	public GameObject player;
	Transform playerT;
	//Camera cam;
	public float lifeTime;

	public int damageToGive;

	//float angleBetween = 0.0f;
	Transform target;

	void Update()
	{
		//if(Input.GetMouseButtonDown(0)){
			//bulletForward ();
		//}

		Vector3 v = new Vector3 (1,0,0);
		transform.Translate( v *  speed * Time.deltaTime);


		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0) {
			Destroy (gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D other){
		if ((other.gameObject.tag == "Enemy") || (other.gameObject.tag == "Boss")) {

			other.gameObject.GetComponent<ZombieHealth>().HurtEnemy(damageToGive);
			Destroy (gameObject);	
		}

		if (other.gameObject.tag == "Wall") {
			Destroy (gameObject);
		}
	}

	//void Update(){
	//rb.velocity = transform.forward * bulletSpeed;
	//	var direction = Mathf.Atan2(player.transform.right.x, player.transform.right.y) * Mathf.Rad2Deg;
	//	transform.Translate(direction * bulletSpeed * Time.deltaTime);


	//}
	//void bulletForward(){

	//	if (1 == 1) {
			//	anim.setTrigger("attack")
			//bulletForward ();
	//		float camDis = cam.transform.position.y - playerT.position.y;

	//		Vector3 mouse = cam.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, camDis));

	//		var targetDir = mouse - transform.position;
			//Debug.Log (transform.forward);
	//		angleBetween = Vector3.Angle (transform.forward, targetDir);

	//		rb.velocity = transform.forward * speed;
	//	}

		//float camDis = cam.transform.position.y - playerT.position.y;

		//Vector3 mouse = cam.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, camDis));
		//var direction = new Vector3(mouse.x - playerT.position.x, mouse.y - playerT.position.y,0);
		//float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
		//Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
		//transform.rotation = Quaternion.Slerp(transform.rotation, q, bulletRotation* Time.deltaTime);
		// ===== MOVEMENT =====

		//float step = bulletSpeed * Time.deltaTime;
		//transform.position = Vector3.forward;
		//transform.Translate(Vector3.forward * step);
	}
