using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;// we need this namespace in order to access UI elements within our script
using UnityEngine.SceneManagement; // neded in order to load scenes

public class countDownTimerScript : MonoBehaviour {

	public float timeRemaining = 100;
	Text timer;

	// Use this for initialization
	void Start () {
		timer = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		timeRemaining -= Time.deltaTime;
	}

	void OnGUI () {
		if (timeRemaining > 0) {
			timer.text = "Time: " + (int) timeRemaining;
		} else {
			SceneManager.LoadScene (0);
		}
	}
}
