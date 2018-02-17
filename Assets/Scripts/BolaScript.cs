using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BolaScript : MonoBehaviour {

	public Rigidbody2D rb;
	public float forca;
	bool gameStarted = false;
	public GerenciadorComp gc;

	// Use this for initialization
	void Start () {
		gc = GameObject.FindWithTag ("gc").GetComponent<GerenciadorComp>();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Fire1") && !gameStarted ) {
			gameStarted = true;
			rb.AddForce (new Vector2 (forca, forca));
		}
	}

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "sideDown") {
			gc.gameOver ();
			SceneManager.LoadScene ("Start");	
		}
	}
}


