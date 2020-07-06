using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionScript : MonoBehaviour {

	playerUserControllerScript playerUserController;

	public float moveOnIce = 1; 

	void Start () {
		playerUserController = GetComponent <playerUserControllerScript> ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Ice")) {
			playerUserController.move = moveOnIce;
		} else {
			playerUserController.move = playerUserController.speedMove;
		}

	}
}
