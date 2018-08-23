using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	private Transform playerT;
	private Camera cam;
    public GunController gun;
    public float speed;             //Floating point variable to store the player's movement speed.
	public Transform shot;
    public GameObject gc;
    public GameObject player;
    public Sprite shipModel1;
    public Sprite shipModel2;
    public Sprite shipModel3;

    private static int shipModel = 1;

	// Use this for initialization
	void Start()
	{
		//Get and store a reference to the Rigidbody2D component so that we can access it.
		this.rb2d = this.GetComponent<Rigidbody2D> ();
		this.playerT = this.GetComponent<Transform> ();
		this.cam = GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera>();
        shipModel = gc.gameObject.GetComponent<ShopUIManager>().returnShipSkin();
        this.gameObject.GetComponent<GunController>().setUpShipDetails();
        this.setRightSprite();
	}


    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
	{
        this.shoot();
        this.move();
    }

	void move()
	{
        // ====== ROTATION =====
        float camDis = cam.transform.position.y - playerT.position.y;

        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - playerT.position.y, mouse.x - playerT.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        rb2d.rotation = angle;

        // ===== MOVEMENT =====

        var direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += Vector3.ClampMagnitude(direction, 0.7f) * speed * Time.deltaTime;
    }

    void shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            gun.isFiring = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            gun.isFiring = false;
        }
    }
    
    public void setRightSprite()
    {
        if(shipModel == 1)
        {
            player.gameObject.GetComponent<SpriteRenderer>().sprite = shipModel1;
        }
        else if (shipModel == 2)
        {
            player.gameObject.GetComponent<SpriteRenderer>().sprite = shipModel2;
        }
        else if (shipModel == 3)
        {
            player.gameObject.GetComponent<SpriteRenderer>().sprite = shipModel3;
        }
    }
}