﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadmove : MonoBehaviour {

	public float Speed;
	Vector2 offset;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		offset = new Vector2 (0, Time.time * Speed);
		GetComponent<Renderer> ().material.mainTextureOffset = offset;  
	}
}
