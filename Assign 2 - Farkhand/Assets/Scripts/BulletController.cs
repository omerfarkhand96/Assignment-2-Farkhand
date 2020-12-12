﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public float speed = 1f;

    private GameObject player;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 pos = transform.position;
        Vector3 direction = player.transform.position - transform.position;
        direction.y += 0.5f;
        direction = Vector3.Normalize(direction) * speed / 100f;
        pos = pos + direction;
        transform.position = pos;
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }
}
