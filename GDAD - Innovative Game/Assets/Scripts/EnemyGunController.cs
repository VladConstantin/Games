using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunController : MonoBehaviour {

    public int gunDMG; // remove this
    public int enemyType; 

    public EnemyShotMovement shot;
    public float shotSpeed;

    public float timeBetweenShots;
    private float shotCounter;

    public GameObject wpn1;
    public GameObject wpn2;
    public GameObject wpn3;
    public GameObject wpn4;

    public Transform wpnTransform1;
    public Transform wpnTransform2;
    public Transform wpnTransform3;
    public Transform wpnTransform4;
    public Transform wpnTransform5;
    public Transform wpnTransform6;
    public Transform wpnTransform7;
    public Transform wpnTransform8;

    public void wpnType()
    {
        switch (enemyType)
        {
            case 2:
                enemyType2();
                break;
            case 3:
                enemyType3();
                break;
            case 4:
                enemyType4();
                break;
            case 5:
                enemyType5();
                break;
            default:

                break;
        }
    }

    public void enemyType2()
	{
        shotCounter -= Time.deltaTime;
        if (shotCounter <= 0)
        {
			GetComponent<AudioSource> ().Play ();
            shotCounter = timeBetweenShots;
            EnemyShotMovement newBullet = Instantiate(shot, wpnTransform1.position, wpnTransform1.rotation) as EnemyShotMovement;
            newBullet.damageToGive = gunDMG;
            newBullet.speed = shotSpeed;
        }
    }

    public void enemyType3()
    {
		shotCounter -= Time.deltaTime;
		if (shotCounter <= 0)
		{
			GetComponent<AudioSource> ().Play ();
            shotCounter = timeBetweenShots;
            EnemyShotMovement newBullet = Instantiate(shot, wpnTransform1.position, wpnTransform1.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet2 = Instantiate(shot, wpnTransform2.position, wpnTransform2.rotation) as EnemyShotMovement;
            newBullet.damageToGive = gunDMG;
            newBullet.speed = shotSpeed;
            newBullet2.damageToGive = gunDMG;
            newBullet2.speed = shotSpeed;
        }
    }

    public void enemyType4()
	{
		shotCounter -= Time.deltaTime;
		if (shotCounter <= 0)
		{
			GetComponent<AudioSource> ().Play ();
            shotCounter = timeBetweenShots;
            EnemyShotMovement newBullet = Instantiate(shot, wpnTransform1.position, wpnTransform1.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet2 = Instantiate(shot, wpnTransform2.position, wpnTransform2.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet3 = Instantiate(shot, wpnTransform3.position, wpnTransform3.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet4 = Instantiate(shot, wpnTransform4.position, wpnTransform4.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet5 = Instantiate(shot, wpnTransform5.position, wpnTransform5.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet6 = Instantiate(shot, wpnTransform6.position, wpnTransform6.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet7 = Instantiate(shot, wpnTransform7.position, wpnTransform7.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet8 = Instantiate(shot, wpnTransform8.position, wpnTransform8.rotation) as EnemyShotMovement;
            newBullet.damageToGive = gunDMG;
            newBullet.speed = shotSpeed;
            newBullet2.damageToGive = gunDMG;
            newBullet2.speed = shotSpeed;
            newBullet3.damageToGive = gunDMG;
            newBullet3.speed = shotSpeed;
            newBullet4.damageToGive = gunDMG;
            newBullet4.speed = shotSpeed;
            newBullet5.damageToGive = gunDMG;
            newBullet5.speed = shotSpeed;
            newBullet6.damageToGive = gunDMG;
            newBullet6.speed = shotSpeed;
            newBullet7.damageToGive = gunDMG;
            newBullet7.speed = shotSpeed;
            newBullet8.damageToGive = gunDMG;
            newBullet8.speed = shotSpeed;
        }
    }

    public void enemyType5()
	{
		shotCounter -= Time.deltaTime;
		if (shotCounter <= 0)
		{
			GetComponent<AudioSource> ().Play ();
            shotCounter = timeBetweenShots;
            EnemyShotMovement newBullet = Instantiate(shot, wpnTransform1.position, wpnTransform1.rotation) as EnemyShotMovement;
            EnemyShotMovement newBullet2 = Instantiate(shot, wpnTransform2.position, wpnTransform2.rotation) as EnemyShotMovement;
            newBullet.damageToGive = gunDMG;
            newBullet.speed = shotSpeed;
            newBullet2.damageToGive = gunDMG;
            newBullet2.speed = shotSpeed;
        }
    }
}
