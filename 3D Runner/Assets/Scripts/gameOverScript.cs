using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // neded in order to load scenes

public class gameOverScript : MonoBehaviour {


        void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("GameOver")) {
			//playerCharacter.Death();
			EndGame ();
		}
	}

	void EndGame () {
		SceneManager.LoadScene (0); //this will load our first level from our build settings. "1" is the second scene in our game
									//Application.LoadLevel (0);
	}
}
