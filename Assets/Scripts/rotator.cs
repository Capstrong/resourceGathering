﻿using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.up, speed);
	}
}
