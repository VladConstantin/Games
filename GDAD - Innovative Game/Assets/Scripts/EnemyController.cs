using UnityEngine;

public class EnemyController : MonoBehaviour {

    public GameObject player;
    public GameObject currentEnemy;
    public GameObject gc;
    public EnemyGunController fire;

    public bool canShoot;

    public int enemyHealth;
    private int currentHealth; 
    public float enemySpeed;
	public float enemyRotationSpeed;

    public int pointsToGive;

	Transform enemyTransform;
	Transform playerTransform;

	public AudioClip deathSound;

	void Start() 
	{
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        int x = gc.gameObject.GetComponent<GameController>().getRound();
        if (x >= 10) 
        {
            enemyHealth *= 2;
        }
        else if (x >= 25) {
            enemyHealth *= 3;
        }

        currentHealth = enemyHealth;
    }

	void Awake()
	{
		enemyTransform = GetComponent<Transform> ();
	}

    void FixedUpdate()
	{
        this.move();
        if (canShoot) this.shoot();
        this.checkHP();
    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            gc.gameObject.GetComponent<GameController>().hit();
			GetComponent<AudioSource>().PlayOneShot(deathSound);
            Destroy(gameObject);
        }
    }

    public void move()
    {
        //ROTATION
        var direction = playerTransform.position - enemyTransform.position;
        float angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * enemyRotationSpeed);
        //MOVEMENT
        float step = enemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, step);
    }

    public void shoot()
    {
        fire.gameObject.GetComponent<EnemyGunController>().wpnType();
    }

    public void checkHP()
    {
        if (currentHealth <= 0)
        {
            gc.gameObject.GetComponent<GameController>().addPoints(pointsToGive);
            gc.gameObject.GetComponent<GameController>().spawnPowerUp(enemyTransform);
			GetComponent<AudioSource>().PlayOneShot(deathSound);
            Destroy(this.gameObject);
        }
    }

    public void dmgEnemy(int dmg)
    {
        currentHealth -= dmg;   
    }
}
