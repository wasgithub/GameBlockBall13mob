using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoScript : MonoBehaviour {

	public GerenciadorComp gc;

	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag ("gc").GetComponent<GerenciadorComp>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Bola") {
			gc.IncrementarPontos();
			Destroy (gameObject);
		}
	}
}
