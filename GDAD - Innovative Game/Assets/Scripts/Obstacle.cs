using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    private float speed = 3;    private float lifeTime = 20;
    public GameObject gc;

    // Update is called once per frame
    void FixedUpdate () {

        Vector3 v = new Vector3(1, 0, 0);        transform.Translate(v * speed * Time.deltaTime);        lifeTime -= Time.deltaTime;        if (lifeTime <= 0)        {            Destroy(gameObject);        }
    }

    void OnTriggerEnter2D(Collider2D other)    {        if (other.gameObject.tag == "enemy")        {            other.gameObject.GetComponent<EnemyController>().dmgEnemy(1);            Destroy(gameObject);        }        if (other.gameObject.tag == "Player")        {
            gc.gameObject.GetComponent<GameController>().hit();
            Destroy(gameObject);        }        if (other.gameObject.tag == "Shot")        {
            Destroy(gameObject);        }    }
}
