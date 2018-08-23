using UnityEngine;

public class GunController : MonoBehaviour {

    private float shotCounter;
    public bool isFiring;
    static int shotType = 1;
    public GameObject gc;

    // +++++++++++++++ SHOT +++++++++++++++
    public ShotMovement shotType1;
    public ShotMovement shotType2;

    private static int bgunDMG = 1;
    private static int bshotLevel = 1;
    private float btimeBetweenShots = 0.5f;
    private float bshotSpeed = 3;

    private static int ggunDMG = 1;
    private static int gshotLevel = 1;
    private float gtimeBetweenShots = 0.5f;
    private float gshotSpeed = 3;
    // +++++++++++++++ END SHOT +++++++++++++++


    // +++++++++++++++ BLUE SHOT +++++++++++++++
    public GameObject wpn1;
    public GameObject wpn1Lvl2;
    public GameObject wpn1Lvl3;
    public GameObject wpn1Lvl4;

    public Transform rsTransform1;
    public Transform rsTransform2_1;
    public Transform rsTransform2_2;
    public Transform rsTransform3_1;
    public Transform rsTransform3_2;
    public Transform rsTransform3_3;
    public Transform rsTransform4_1;
    public Transform rsTransform4_2;
    public Transform rsTransform4_3;
    public Transform rsTransform4_4;
    public Transform rsTransform4_5;
    // +++++++++++++++ END BLUE SHOT  +++++++++++++++

    // +++++++++++++++ GREEN SHOT +++++++++++++++
    public GameObject wpn2;
    public GameObject wpn2Lvl2;
    public GameObject wpn2Lvl3;
    public GameObject wpn2Lvl4;

    public Transform gsTransform1;
    public Transform gsTransform1_2;

    public Transform gsTransform2_1;
    public Transform gsTransform2_2;
    public Transform gsTransform2_3;
    public Transform gsTransform2_4;

    public Transform gsTransform3_1;
    public Transform gsTransform3_2;
    public Transform gsTransform3_3;
    public Transform gsTransform3_4;
    public Transform gsTransform3_5;
    public Transform gsTransform3_6;

    public Transform gsTransform4_1;
    public Transform gsTransform4_2;
    public Transform gsTransform4_3;
    public Transform gsTransform4_4;
    public Transform gsTransform4_5;
    public Transform gsTransform4_6;
    public Transform gsTransform4_7;
    public Transform gsTransform4_8;
    public Transform gsTransform4_9;
    // +++++++++++++++ END GREEN SHOT  +++++++++++++++

	// +++++++++++++++ AUDIO  +++++++++++++++
	public AudioClip shootSound;
	private AudioSource source;
	// +++++++++++++++ END AUDIO  +++++++++++++++


    void Start()
    {
        setUpShipDetails();
    }

	void Awake() {
		source = GetComponent<AudioSource> ();
	}

    public void upgrade(int powerUp, int gunUp, int dmgUp, float speedUp)
    {
        shotType = powerUp;
        if(shotType == 1)
        {
            if(bshotLevel <4) bshotLevel += gunUp;
            bgunDMG += dmgUp;
            btimeBetweenShots -= speedUp;
        } 
        else if(shotType == 2)
        {
            if(gshotLevel <4) gshotLevel += gunUp;
            ggunDMG += dmgUp;
            gtimeBetweenShots -= speedUp;
        }
    }

    public void shotTypeUpdate(int x)
    {
        switch (shotType)
        {
            case 1:
                shotType = 1;
                break;
            case 2:
                shotType = 2;
                break;
            case 3:
                shotType = 3;
                break;
            default:
                shotType = 1;
                break;
        }
    }

	void FixedUpdate ()
    {
        this.shoot();
    }

    public void shoot()
    {
        switch (shotType)
        {
            case 1:
                if(bshotLevel == 1)
                {
                    shootType11();
                }else if(bshotLevel == 2)
                {
                    shootType12();
                }
                else if (bshotLevel == 3)
                {
                    shootType13();
                }
                else if (bshotLevel >= 4)
                {
                    shootType14();
                }
                break;
            case 2:
                if (gshotLevel == 1)
                {
                    shootType2();
                }
                else if (gshotLevel == 2)
                {
                    shootType22();
                }
                else if (gshotLevel == 3)
                {
                    shootType23();
                }
                else if (gshotLevel >= 4)
                {
                    shootType24();
                }
                break;
            default:
                break;
        }
    }

    //++++++++++++++++++++++++++++++++++++++++++++++++++++ SHOT TYPE 1 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public void shootType11()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
            if (shotCounter <= 0)
            {
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet = Instantiate(shotType1, rsTransform1.position, rsTransform1.rotation) as ShotMovement;
                newBullet.damageToGive = bgunDMG;
                newBullet.speed = bshotSpeed;
            }
        }
    }

    public void shootType12()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType1, rsTransform2_1.position, rsTransform2_1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType1, rsTransform2_2.position, rsTransform2_2.rotation) as ShotMovement;
                newBullet1.damageToGive = bgunDMG;
                newBullet1.speed = bshotSpeed;
                newBullet2.damageToGive = bgunDMG;
                newBullet2.speed = bshotSpeed;
            }
        }
    }

    public void shootType13()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType1, rsTransform3_1.position, rsTransform3_1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType1, rsTransform3_2.position, rsTransform3_2.rotation) as ShotMovement;
                ShotMovement newBullet3 = Instantiate(shotType1, rsTransform3_3.position, rsTransform3_3.rotation) as ShotMovement;
                newBullet1.damageToGive = bgunDMG;
                newBullet1.speed = bshotSpeed;
                newBullet2.damageToGive = bgunDMG;
                newBullet2.speed = bshotSpeed;
                newBullet3.damageToGive = bgunDMG;
                newBullet3.speed = bshotSpeed;
            }
        }
    }

    public void shootType14()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType1, rsTransform4_1.position, rsTransform4_1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType1, rsTransform4_2.position, rsTransform4_2.rotation) as ShotMovement;
                ShotMovement newBullet3 = Instantiate(shotType1, rsTransform4_3.position, rsTransform4_3.rotation) as ShotMovement;
                ShotMovement newBullet4 = Instantiate(shotType1, rsTransform4_4.position, rsTransform4_4.rotation) as ShotMovement;
                ShotMovement newBullet5 = Instantiate(shotType1, rsTransform4_5.position, rsTransform4_5.rotation) as ShotMovement;
                newBullet1.damageToGive = bgunDMG;
                newBullet1.speed = bshotSpeed;
                newBullet2.damageToGive = bgunDMG;
                newBullet2.speed = bshotSpeed;
                newBullet3.damageToGive = bgunDMG;
                newBullet3.speed = bshotSpeed;
                newBullet4.damageToGive = bgunDMG;
                newBullet4.speed = bshotSpeed;
                newBullet5.damageToGive = bgunDMG;
                newBullet5.speed = bshotSpeed;
            }
        }
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++ END SHOT TYPE 1 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //++++++++++++++++++++++++++++++++++++++++++++++++++++ SHOT TYPE 2 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public void shootType2()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType2, gsTransform1.position, gsTransform1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType2, gsTransform1_2.position, gsTransform1_2.rotation) as ShotMovement;
                newBullet1.damageToGive = ggunDMG;
                newBullet1.speed = gshotSpeed;
                newBullet2.damageToGive = ggunDMG;
                newBullet2.speed = gshotSpeed;
            }
        }
    }

    public void shootType22()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType2, gsTransform2_1.position, gsTransform2_1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType2, gsTransform2_2.position, gsTransform2_2.rotation) as ShotMovement;
                ShotMovement newBullet3 = Instantiate(shotType2, gsTransform2_3.position, gsTransform2_3.rotation) as ShotMovement;
                ShotMovement newBullet4 = Instantiate(shotType2, gsTransform2_4.position, gsTransform2_4.rotation) as ShotMovement;
                newBullet1.damageToGive = ggunDMG;
                newBullet1.speed = gshotSpeed;
                newBullet2.damageToGive = ggunDMG;
                newBullet2.speed = gshotSpeed;
                newBullet3.damageToGive = ggunDMG;
                newBullet3.speed = gshotSpeed;
                newBullet4.damageToGive = ggunDMG;
                newBullet4.speed = gshotSpeed; 
            }
        }
    }

    public void shootType23()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.PlayOneShot (shootSound);
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType2, gsTransform3_1.position, gsTransform3_1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType2, gsTransform3_2.position, gsTransform3_2.rotation) as ShotMovement;
                ShotMovement newBullet3 = Instantiate(shotType2, gsTransform3_3.position, gsTransform3_3.rotation) as ShotMovement;
                ShotMovement newBullet4 = Instantiate(shotType2, gsTransform3_4.position, gsTransform3_4.rotation) as ShotMovement;
                ShotMovement newBullet5 = Instantiate(shotType2, gsTransform3_5.position, gsTransform3_5.rotation) as ShotMovement;
                ShotMovement newBullet6 = Instantiate(shotType2, gsTransform3_6.position, gsTransform3_6.rotation) as ShotMovement;
                newBullet1.damageToGive = ggunDMG;
                newBullet1.speed = gshotSpeed;
                newBullet2.damageToGive = ggunDMG;
                newBullet2.speed = gshotSpeed;
                newBullet3.damageToGive = ggunDMG;
                newBullet3.speed = gshotSpeed;
                newBullet4.damageToGive = ggunDMG;
                newBullet4.speed = gshotSpeed;
                newBullet5.damageToGive = ggunDMG;
                newBullet5.speed = gshotSpeed;
                newBullet6.damageToGive = ggunDMG;
                newBullet6.speed = gshotSpeed;   
            }
        }
    }

    public void shootType24()
    {
        shotCounter -= Time.deltaTime;
        if (isFiring)
        {
			if (shotCounter <= 0)
			{
				source.Play();
                shotCounter = btimeBetweenShots;
                ShotMovement newBullet1 = Instantiate(shotType2, gsTransform4_1.position, gsTransform4_1.rotation) as ShotMovement;
                ShotMovement newBullet2 = Instantiate(shotType2, gsTransform4_2.position, gsTransform4_2.rotation) as ShotMovement;
                ShotMovement newBullet3 = Instantiate(shotType2, gsTransform4_3.position, gsTransform4_3.rotation) as ShotMovement;
                ShotMovement newBullet4 = Instantiate(shotType2, gsTransform4_4.position, gsTransform4_4.rotation) as ShotMovement;
                ShotMovement newBullet5 = Instantiate(shotType2, gsTransform4_5.position, gsTransform4_5.rotation) as ShotMovement;
                ShotMovement newBullet6 = Instantiate(shotType2, gsTransform4_6.position, gsTransform4_6.rotation) as ShotMovement;
                ShotMovement newBullet7 = Instantiate(shotType2, gsTransform4_7.position, gsTransform4_7.rotation) as ShotMovement;
                ShotMovement newBullet8 = Instantiate(shotType2, gsTransform4_8.position, gsTransform4_8.rotation) as ShotMovement;
                ShotMovement newBullet9 = Instantiate(shotType2, gsTransform4_9.position, gsTransform4_9.rotation) as ShotMovement;
                newBullet1.damageToGive = ggunDMG;
                newBullet1.speed = gshotSpeed;
                newBullet2.damageToGive = ggunDMG;
                newBullet2.speed = gshotSpeed;
                newBullet3.damageToGive = ggunDMG;
                newBullet3.speed = gshotSpeed;
                newBullet4.damageToGive = ggunDMG;
                newBullet4.speed = gshotSpeed;
                newBullet5.damageToGive = ggunDMG;
                newBullet5.speed = gshotSpeed;
                newBullet6.damageToGive = ggunDMG;
                newBullet6.speed = gshotSpeed;
                newBullet7.damageToGive = ggunDMG;
                newBullet7.speed = gshotSpeed;
                newBullet8.damageToGive = ggunDMG;
                newBullet8.speed = gshotSpeed;
                newBullet9.damageToGive = ggunDMG;
                newBullet9.speed = gshotSpeed;
            }
        }
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++ END SHOT TYPE 2 +++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    public void setUpShipDetails()
    {
        // BLUE
        bgunDMG = gc.gameObject.GetComponent<ShopUIManager>().returnBlzrDMG();
        bshotLevel = gc.gameObject.GetComponent<ShopUIManager>().returnBlzrLVL();
        int shSpeedLVL = gc.gameObject.GetComponent<ShopUIManager>().returnBlzrSpeed();

        btimeBetweenShots -= 0.01f * shSpeedLVL;

        //GREEN
        ggunDMG = gc.gameObject.GetComponent<ShopUIManager>().returnGlzrDMG();
        gshotLevel = gc.gameObject.GetComponent<ShopUIManager>().returnGlzrLVL();
        int ghSpeedLVL = gc.gameObject.GetComponent<ShopUIManager>().returnGlzrSpeed();

        gtimeBetweenShots -= 0.01f * ghSpeedLVL;
    }
}
