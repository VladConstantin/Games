﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

    private float speed = 3;
    public GameObject gc;

    // Update is called once per frame
    void FixedUpdate () {

        Vector3 v = new Vector3(1, 0, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
            gc.gameObject.GetComponent<GameController>().hit();
            Destroy(gameObject);
            Destroy(gameObject);
}