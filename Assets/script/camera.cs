﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    GameObject player;
	// Use this for initialization
	void Start () {
        this.player = GameObject.Find("player");
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPos = this.player.transform.position;
        transform.position = new Vector3(transform.position.x, playerPos.y, transform.position.z);
	}
}
