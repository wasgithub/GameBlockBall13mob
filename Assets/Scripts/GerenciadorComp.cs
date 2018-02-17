using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GerenciadorComp : MonoBehaviour {

	public static int pontos = 0;
	public Text pontosText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pontos == 4) {
			SceneManager.LoadScene ("Start");	
		}		
	}

	public void IncrementarPontos() {
		pontos++;
		pontosText.text = "Score: " + pontos;
	}

	public void gameOver() {
		pontos = 0;
	}
}
