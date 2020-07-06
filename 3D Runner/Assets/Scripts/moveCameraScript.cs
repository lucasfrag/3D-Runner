using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCameraScript : MonoBehaviour {

	playerUserControllerScript playerUserController;

	public float speedMove = 4.0f;

	// Use this for initialization
	void Start () {
		//playerUserController = GetComponent <playerUserControllerScript> ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, speedMove * Time.deltaTime);
	}
}
