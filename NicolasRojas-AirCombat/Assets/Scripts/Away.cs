﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Away : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.Translate(0.0f,0.0f,0.7f);
		this.transform.Rotate(0.0f,0.0f,1.0f);
	}
}
