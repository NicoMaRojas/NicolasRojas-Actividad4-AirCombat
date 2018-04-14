using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Misil1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		this.transform.Translate(0.0f,0.0f,1.5f);

	}

	void OnCollisionEnter(Collision collision){

		//Cuando el misil colisiona con la plataforma
		//la elimina

		Destroy (collision.collider.gameObject);

		Destroy (this.gameObject);
	}
}
