using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraScript : MonoBehaviour {

	public float velocidade;
	public 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Fire1 - botao esquerdo do mouse ou toque na tela do celular
		if (Input.GetButton ("Fire1")) {

			//obtem a posicao xy do toque na tela e transforma em coordenada
			//para o mundo
			Vector2 posicaoMouse = Input.mousePosition;
			posicaoMouse = Camera.main.ScreenToWorldPoint (posicaoMouse);

			//cria a coordenada para onde o jogador deve se deslocar e faz seu deslocamento
			posicaoMouse = new Vector2(posicaoMouse.x, -3.5f);
			transform.position = Vector2.Lerp (transform.position, posicaoMouse, velocidade * Time.deltaTime);

		}
	}

}
