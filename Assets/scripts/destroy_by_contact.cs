﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_by_contact : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerExpolosion;
	public int scoreValue;
	//private GameController gameController;

	void Start (){
		/*GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null){
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null){
			Debug.Log ("Cannot find 'GameController' script");
		}*/
	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Boundray"){
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag == "Player"){
			Instantiate(playerExpolosion, other.transform.position, other.transform.rotation);
			//gameController.GameOver ();
		}
		//gameController.AddScore (scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
	
}
