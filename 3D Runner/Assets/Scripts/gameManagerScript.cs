using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManagerScript : MonoBehaviour {

	public float zScenePosition = 10;

	public Transform piece1;
	public Transform piece2;
	public Transform piece3;
	public Transform piece4;
	public Transform piece5;
	public Transform piece6;
	public Transform piece7;
	public Transform piece8;
	public Transform piece9;
	public Transform piece10;
	public Transform piece11;
	public Transform piece12;
	public Transform piece13;
	public Transform piece14;
	public Transform piece15;
	public Transform piece16;
	public Transform piece17;
	public Transform piece18;
	public Transform piece19;
	public Transform piece20;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (zScenePosition < 1500) {

			int randomNumber = Random.Range (0, 20);

			if (randomNumber == 0) {
				Instantiate (piece1, new Vector3 (0, 0, zScenePosition), piece1.rotation);
			}

			if (randomNumber == 1) {
				Instantiate (piece2, new Vector3 (0, 0, zScenePosition), piece2.rotation);
			}

			if (randomNumber == 2) {
				Instantiate (piece3, new Vector3 (0, 0, zScenePosition), piece3.rotation);
			}

			if (randomNumber == 3) {
				Instantiate (piece4, new Vector3 (0, 0, zScenePosition), piece4.rotation);
			}

			if (randomNumber == 4) {
				Instantiate (piece5, new Vector3 (0, 0, zScenePosition), piece5.rotation);
			}

			if (randomNumber == 5) {
				Instantiate (piece6, new Vector3 (0, 0, zScenePosition), piece6.rotation);
			}

			if (randomNumber == 6) {
				Instantiate (piece7, new Vector3 (0, 0, zScenePosition), piece7.rotation);
			}

			if (randomNumber == 7) {
				Instantiate (piece8, new Vector3 (0, 0, zScenePosition), piece8.rotation);
			}

			if (randomNumber == 8) {
				Instantiate (piece9, new Vector3 (0, 0, zScenePosition), piece9.rotation);
			}

			if (randomNumber == 9) {
				Instantiate (piece10, new Vector3 (0, 0, zScenePosition), piece10.rotation);
			}

			if (randomNumber == 10) {
				Instantiate (piece11, new Vector3 (0, 0, zScenePosition), piece11.rotation);
			}

			if (randomNumber == 11) {
				Instantiate (piece12, new Vector3 (0, 0, zScenePosition), piece12.rotation);
			}

			if (randomNumber == 12) {
				Instantiate (piece13, new Vector3 (0, 0, zScenePosition), piece13.rotation);
			}

			if (randomNumber == 13) {
				Instantiate (piece14, new Vector3 (0, 0, zScenePosition), piece14.rotation);
			}

			if (randomNumber == 14) {
				Instantiate (piece15, new Vector3 (0, 0, zScenePosition), piece15.rotation);
			}

			if (randomNumber == 15) {
				Instantiate (piece16, new Vector3 (0, 0, zScenePosition), piece16.rotation);
			}

			if (randomNumber == 16) {
				Instantiate (piece17, new Vector3 (0, 0, zScenePosition), piece17.rotation);
			}

			if (randomNumber == 17) {
				Instantiate (piece18, new Vector3 (0, 0, zScenePosition), piece18.rotation);
			}

			if (randomNumber == 18) {
				Instantiate (piece19, new Vector3 (0, 0, zScenePosition), piece19.rotation);
			}

			if (randomNumber == 19) {
				Instantiate (piece20, new Vector3 (0, 0, zScenePosition), piece20.rotation);
			}

			zScenePosition += 10;
		}
	}
}
