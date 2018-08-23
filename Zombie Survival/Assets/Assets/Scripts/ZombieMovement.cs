using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour {
	public GameObject myself;
	public float speedZombie;
	public float rotationSpeedZombie;
	public float timeToActivate;
	public bool active;
	//Rigidbody2D rb;
	Transform zombieT;
	Transform playerT;
	UnityEngine.AI.NavMeshAgent nma;
	public HurtPlayer hurtP;
	void Start() 
	{
		playerT = GameObject.FindGameObjectWithTag("Player").transform;
		//nma.GetComponent<UnityEngine.AI.NavMeshAgent> ();
		//rb = GetComponent <Rigidbody2D> ();
		timeToActivate = 0.0f;
	}

	void Awake()
	{
		zombieT = GetComponent <Transform> ();
		//playerT = GetComponent <Transform> ();

	}

	void Update()
	{
		if(timeToActivate > 0.0f){
		timeToActivate -= Time.deltaTime;
		}
			//====== ROTATION======
		var direction = playerT.position - zombieT.position;
		//if (gameObject == ZombieNormal){
		float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
		Quaternion q = Quaternion.AngleAxis (angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * rotationSpeedZombie);
		// ===== MOVEMENT =====
		if ((hurtP.getHitCounter() <= 0.0f) && (timeToActivate <= 0.0f)) {
			float step = speedZombie * Time.deltaTime;
			transform.position = Vector3.MoveTowards (transform.position, playerT.position, step);
		}
	}
	public void setTimeToActivate(float t){
		timeToActivate = t;
	}
	public void setActive(bool b){
		active = b;
	}

	public void slow(float f){
		speedZombie *= f;
	}
	public void setSpeed(float f){
		speedZombie = f;
	}
}
